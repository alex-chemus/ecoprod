using Ecoprod.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ecoprod.Views.ProductsView;

namespace Ecoprod.Views.ClientsView;

public partial class ClientsView : Form
{
    private DbHelper db;
    private int currentClientId;

    public ClientsView()
    {
        InitializeComponent();
        this.db = new DbHelper();
        clientPanel.Visible = false;
        editPanel.Visible = false;
        if (UserState.getInstance().rank != Rank.Senior)
        {
            openEditButton.Visible = false;
            addPanel.Visible = false;
            deleteButton.Visible = false;
        }
    }

    private void refreshClientsList()
    {
        clientsListview.Items.Clear();

        string query = $"SELECT * FROM Client";

        var table = db.getRecords(query);

        foreach (DataRow row in table.Rows)
        {
            var listItem = new ListViewItem(row["name"].ToString());
            listItem.Tag = row["id"].ToString();
            clientsListview.Items.Add(listItem);
        }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var name = addNameTextbox.Text;
        bool nameValid = StringFormatter.Check("ФИО", name, 100);

        long phone = 0;
        bool phoneValid = true;
        try
        {
            if (addPhoneTextbox.Text.Length != 11)
            {
                Debug.WriteLine("invalid phone length");
                throw new Exception();
            }
            phone = (long)Convert.ToDouble(addPhoneTextbox.Text);
        }
        catch
        {
            Debug.WriteLine("invalid phone " + addPhoneTextbox.Text.Length);
            phoneValid = false;
        }

        var email = addEmailTextbox.Text;
        var emailValid = StringFormatter.Check("Email", email, 30);

        if (!nameValid || !phoneValid || !emailValid) return;

        string query = $"INSERT INTO Client (" +
            $"name, phone, email" +
            $") VALUES (" +
            $"'{name}', {phone.ToString()}, '{email}')";

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка добавления клиента");
        }

        addNameTextbox.Text = "";
        addPhoneTextbox.Text = "";
        addEmailTextbox.Text = "";

        refreshClientsList();
    }

    private void ClientsView_Load(object sender, EventArgs e)
    {
        refreshClientsList();
    }

    private void clientsListview_MouseClick(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < clientsListview.Items.Count; i++)
        {
            var rect = clientsListview.GetItemRect(i);
            if (rect.Contains(e.Location))
            {
                Debug.WriteLine(clientsListview.Items[i].Tag);

                int clientId = Int32.Parse(clientsListview.Items[i].Tag.ToString());

                string query = $"SELECT * FROM Client WHERE id = {clientId}";

                var row = db.getSignelRecord(query);

                clientNameLabel.Text = row["name"].ToString();
                clientPhoneLabel.Text = "Телефон: " + row["phone"].ToString();
                clientEmailLabel.Text = "Email: " + row["email"].ToString();

                clientPanel.Visible = true;

                currentClientId = clientId;
            }
        }
    }

    private void openEditButton_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;

        string query = $"SELECT * FROM Client WHERE id = {currentClientId}";

        var row = db.getSignelRecord(query);

        editNameTextbox.Text = row["name"].ToString();
        editPhoneTextbox.Text = row["phone"].ToString();
        editEmailTextbox.Text = row["email"].ToString();

        clientPanel.Visible = false;
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        var name = editNameTextbox.Text;
        bool nameValid = StringFormatter.Check("ФИО", name, 100);

        long phone = 0;
        bool phoneValid = true;
        try
        {
            if (editPhoneTextbox.Text.Length != 11) throw new Exception();
            phone = (long)Convert.ToDouble(editPhoneTextbox.Text);
        }
        catch
        {
            phoneValid = false;
        }

        var email = editEmailTextbox.Text;
        var emailValid = StringFormatter.Check("Email", email, 30);

        if (!nameValid || !phoneValid || !emailValid) return;

        string query = $"UPDATE Client SET " +
            $"name = '{name}', " +
            $"phone = {phone}, " +
            $"email = '{email}' " +
            $"WHERE id = {currentClientId}";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка редактирования клиента");
        }

        editPanel.Visible = false;

        refreshClientsList();
    }

    private void productsButton_Click(object sender, EventArgs e)
    {
        new ProductsView.ProductsView().Show();
        this.Hide();
    }

    private void requestsButton_Click(object sender, EventArgs e)
    {
        new RequestsView.RequestsView().Show();
        this.Hide();
    }

    private void ordersButton_Click(object sender, EventArgs e)
    {
        new OrdersView.OrdersView().Show();
        this.Hide();
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Удалить клиента?", "Удалить клиента?", MessageBoxButtons.YesNo);
    
        if (result == DialogResult.Yes)
        {
            string query = $"DELETE FROM Client WHERE id = {currentClientId}";
            db.InsertRecord(query);
            clientPanel.Visible = false;
            editPanel.Visible = false;
            refreshClientsList();
        }
    }
}


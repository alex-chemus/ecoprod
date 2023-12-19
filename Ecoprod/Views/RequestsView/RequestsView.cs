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

namespace Ecoprod.Views.RequestsView;

public partial class RequestsView : Form
{
    private DbHelper db;
    private int currentRequestId;

    public RequestsView()
    {
        InitializeComponent();
        this.db = new DbHelper();
        requestPanel.Visible = false;
        editPanel.Visible = false;
    }

    private void refreshRequestsList()
    {
        requestsListView.Items.Clear();

        string query = $"SELECT " +
            $"Request.amount, Request.id, Product.name " +
            $"FROM Request " +
            $"LEFT JOIN Product ON Request.productId = Product.id;";

        var table = db.getRecords(query);

        foreach (DataRow row in table.Rows)
        {
            string requestString = row["name"].ToString() + " " + row["amount"];
            var listItem = new ListViewItem(requestString);
            listItem.Tag = row["id"].ToString();
            requestsListView.Items.Add(listItem);
        }
    }

    private void openEditButton_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;

        string query = $"SELECT * FROM Request WHERE id = {currentRequestId}";

        Debug.WriteLine(query);

        var row = db.getSignelRecord(query);

        int selectedProductIndex = 1;
        int selectedClientIndex = 1;

        for (int i = 0; i < editProductCombobox.Items.Count; i++)
        {
            if ((editProductCombobox.Items[i] as ComboItem).getId() == (int)row["productId"])
            {
                selectedProductIndex = i;
            }
        }

        for (int i = 0; i < editClientCombobox.Items.Count; i++)
        {
            if ((editClientCombobox.Items[i] as ComboItem).getId() == (int)row["clientId"])
            {
                selectedClientIndex = i;
            }
        }

        editProductCombobox.SelectedIndex = selectedProductIndex;
        editClientCombobox.SelectedIndex = selectedClientIndex;
        editAmountNumeric.Value = (int)row["amount"];
        editCreationDatePicker.Value = DateTime.Parse(row["creationDate"].ToString());

        requestPanel.Visible = false;
    }

    private List<ComboItem> getProductsDataSource()
    {
        var products = new List<ComboItem>();

        string query = "SELECT * FROM Product";

        var table = db.getRecords(query);
        foreach (DataRow row in table.Rows)
        {
            int id = (int)row["id"];
            string title = row["name"].ToString();
            products.Add(new ComboItem(id, title));
        }

        return products;
    }

    private List<ComboItem> getClientsDataSource()
    {
        var clients = new List<ComboItem>();

        string query = "SELECT * FROM Client";
        var table = db.getRecords(query);

        foreach (DataRow row in table.Rows)
        {
            int id = (int)row["id"];
            string title = row["name"].ToString();
            clients.Add(new ComboItem(id, title));
        }

        return clients;
    }

    private void RequestsView_Load(object sender, EventArgs e)
    {
        refreshRequestsList();

        addProductCombobox.DataSource = getProductsDataSource();
        addClientCombobox.DataSource = getClientsDataSource();
        editProductCombobox.DataSource = getProductsDataSource();
        editClientCombobox.DataSource = getClientsDataSource();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        int productId = (addProductCombobox.SelectedItem as ComboItem).getId();
        int clientId = (addClientCombobox.SelectedItem as ComboItem).getId();
        int amount = (int)addAmountNumeric.Value;
        DateTime dateTime = addCreationDatePicker.Value;

        string query = $"INSERT INTO Request (" +
            $"productId, clientId, amount, creationDate" +
            $") VALUES (" +
            $"{productId}, {clientId}, {amount}, '{dateTime.ToString("yyyy-MM-dd")}')";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка добавления заявки");
        }

        addAmountNumeric.Value = 0;

        refreshRequestsList();
    }

    private void requestsListView_MouseClick(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < requestsListView.Items.Count; i++)
        {
            var rect = requestsListView.GetItemRect(i);
            if (rect.Contains(e.Location))
            {
                int requestId = Int32.Parse(requestsListView.Items[i].Tag.ToString());

                string query = $"SELECT " +
                    $"Request.amount, Request.creationDate, Product.name as productName, Client.name as clientName " +
                    $"FROM Request " +
                    $"LEFT JOIN Product ON Request.productId = Product.id " +
                    $"LEFT JOIN Client ON Request.clientId = Client.id " +
                    $"WHERE Request.id = {requestId};";

                var row = db.getSignelRecord(query);

                productNameLabel.Text = row["productName"].ToString();
                clientNameLabel.Text = "Клиент: " + row["clientName"].ToString();
                creationDateLabel.Text = "Дата создания: " + row["creationDate"].ToString();
                amountLabel.Text = "Количество: " + row["amount"].ToString();

                requestPanel.Visible = true;

                currentRequestId = requestId;
            }
        }
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        int productId = (editProductCombobox.SelectedItem as ComboItem).getId();
        int clientId = (editClientCombobox.SelectedItem as ComboItem).getId();
        int amount = (int)editAmountNumeric.Value;
        string creationDate = editCreationDatePicker.Value.ToString("yyyy-MM-dd");

        string query = $"UPDATE Request SET " +
            $"productId = {productId}, " +
            $"clientId = {clientId}, " +
            $"amount = {amount}," +
            $"creationDate = '{creationDate}' " +
            $"WHERE id = {currentRequestId}";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка редактирования заявки");
        }

        editPanel.Visible = false;

        refreshRequestsList();
    }

    private void clientsButton_Click(object sender, EventArgs e)
    {
        new ClientsView.ClientsView().Show();
        Hide();
    }

    private void productsButton_Click(object sender, EventArgs e)
    {
        new ProductsView.ProductsView().Show();
        Hide();
    }

    private void ordersButton_Click(object sender, EventArgs e)
    {
        new OrdersView.OrdersView().Show();
        Hide();
    }
}


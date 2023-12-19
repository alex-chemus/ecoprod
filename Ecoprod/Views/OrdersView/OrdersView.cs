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

namespace Ecoprod.Views.OrdersView;

public partial class OrdersView : Form
{
    private DbHelper db;
    private int currentOrderId;

    public OrdersView()
    {
        InitializeComponent();
        this.db = new DbHelper();
        orderPanel.Visible = false;
        editPanel.Visible = false;
    }

    private void refreshOrdersList()
    {
        ordersListView.Items.Clear();

        string query = $"SELECT " +
            $"Request.amount, Request.id, Product.name " +
            $"FROM `Order` " +
            $"LEFT JOIN Request ON `Order`.id = Request.id " +
            $"LEFT JOIN Product ON Request.productId = Product.id;";

        var table = db.getRecords(query);

        foreach (DataRow row in table.Rows)
        {
            string requestString = row["name"].ToString() + " " + row["amount"] + " шт.";
            var listItem = new ListViewItem(requestString);
            listItem.Tag = row["id"].ToString();
            ordersListView.Items.Add(listItem);
        }
    }

    private void openEditButton_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;

        string query = $"SELECT * FROM `Order` WHERE id = {currentOrderId}";

        Debug.WriteLine(query);

        var row = db.getSignelRecord(query);

        int selectedStatusCombobox = 1;
        int selectedClientIndex = 1;

        for (int i = 0; i < editStatusCombobox.Items.Count; i++)
        {
            if ((editStatusCombobox.Items[i] as ComboItem).getId() == (int)row["statusId"])
            {
                selectedStatusCombobox = i;
            }
        }

        for (int i = 0; i < editManagerCombobox.Items.Count; i++)
        {
            if ((editManagerCombobox.Items[i] as ComboItem).getId() == (int)row["managerId"])
            {
                selectedClientIndex = i;
            }
        }

        editStatusCombobox.SelectedIndex = selectedStatusCombobox;
        editManagerCombobox.SelectedIndex = selectedClientIndex;
        editDeadlinePicker.Value = DateTime.Parse(row["deadline"].ToString());
        editCreationDatePicker.Value = DateTime.Parse(row["creationDate"].ToString());

        orderPanel.Visible = false;
    }

    private List<ComboItem> getStatusDataSource()
    {
        var statuses = new List<ComboItem>();

        string query = "SELECT * FROM Status";

        var table = db.getRecords(query);
        foreach (DataRow row in table.Rows)
        {
            int id = (int)row["id"];
            string title = row["name"].ToString();
            statuses.Add(new ComboItem(id, title));
        }

        return statuses;
    }

    private List<ComboItem> getManagersDataSource()
    {
        var managers = new List<ComboItem>();

        string query = "SELECT * FROM Manager";

        var table = db.getRecords(query);
        foreach (DataRow row in table.Rows)
        {
            int id = (int)row["id"];
            string title = row["name"].ToString();
            managers.Add(new ComboItem(id, title));
        }

        return managers;
    }

    private List<ComboItem> getRequestsDataSource()
    {
        var requests = new List<ComboItem>();

        string query = "SELECT Request.id, Request.amount, Product.name " +
            "FROM Request " +
            "LEFT JOIN Product ON Request.productId = Product.id";

        Debug.WriteLine(query);

        var table = db.getRecords(query);
        foreach (DataRow row in table.Rows)
        {
            int id = (int)row["id"];
            string title = row["name"].ToString() + " " + row["amount"];
            requests.Add(new ComboItem(id, title));
        }

        return requests;
    }

    private void OrdersView_Load(object sender, EventArgs e)
    {
        refreshOrdersList();

        addIdCombobox.DataSource = getRequestsDataSource();
        addStatusCombobox.DataSource = getStatusDataSource();
        editStatusCombobox.DataSource = getStatusDataSource();
        addManagerCombobox.DataSource = getManagersDataSource();
        editManagerCombobox.DataSource = getManagersDataSource();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        int id = (addIdCombobox.SelectedItem as ComboItem).id;
        int statusId = (addStatusCombobox.SelectedItem as ComboItem).id;
        int managerId = (addManagerCombobox.SelectedItem as ComboItem).id;
        DateTime deadline = addDeadlinePicker.Value;
        DateTime creationDate = addCreationDatePicker.Value;

        string query = $"INSERT INTO `Order` (" +
            $"id, statusId, managerId, deadline, creationDate" +
            $") VALUES (" +
            $"{id}, {statusId}, {managerId}, '{deadline.ToString("yyyy-MM-dd")}', '{creationDate.ToString("yyyy-MM-dd")}')";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка добавления заказа");
        }

        refreshOrdersList();
    }

    private void ordersListView_MouseClick(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < ordersListView.Items.Count; i++)
        {
            var rect = ordersListView.GetItemRect(i);
            if (rect.Contains(e.Location))
            {
                int orderId = Int32.Parse(ordersListView.Items[i].Tag.ToString());

                string query = $"SELECT " +
                    $"`Order`.creationDate, `Order`.deadline, " +
                    $"Request.amount, " +
                    $"Product.name as productName, " +
                    $"Client.name as clientName, " +
                    $"Manager.name as managerName " +
                    $"FROM `Order` " +
                    $"LEFT JOIN Request ON `Order`.id = Request.id " +
                    $"LEFT JOIN Product ON Request.productId = Product.id " +
                    $"LEFT JOIN Client ON Request.clientId = Client.id " +
                    $"LEFT JOIN Manager ON `Order`.managerId = Manager.id " +
                    $"WHERE `Order`.id = {orderId};";

                var row = db.getSignelRecord(query);

                productNameLabel.Text = row["productName"].ToString();
                clientNameLabel.Text = "Клиент: " + row["clientName"].ToString();
                managerNameLabel.Text = "Менеджер: " + row["managerName"].ToString();
                creationDateLabel.Text = "Дата создания: " + row["creationDate"].ToString();
                deadlineLabel.Text = "Дата окончания: " + row["deadline"].ToString();
                amountLabel.Text = "Количество: " + row["amount"].ToString();

                orderPanel.Visible = true;

                currentOrderId = orderId;
            }
        }
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        int managerId = (editManagerCombobox.SelectedItem as ComboItem).id;
        int statusId = (editManagerCombobox.SelectedItem as ComboItem).id;
        string deadline = editDeadlinePicker.Value.ToString("yyyy-MM-dd");
        string creationDate = editCreationDatePicker.Value.ToString("yyyy-MM-dd");

        string query = $"UPDATE `Order` SET " +
            $"managerId = {managerId}, " +
            $"statusId = {statusId}, " +
            $"deadline = '{deadline}'," +
            $"creationDate = '{creationDate}' " +
            $"WHERE id = {currentOrderId}";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка редактирования заказа");
        }

        editPanel.Visible = false;

        refreshOrdersList();
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

    private void requestsButton_Click(object sender, EventArgs e)
    {
        new RequestsView.RequestsView().Show();
        Hide();
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Удалить заказ?", "Удалить заказ?", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            string query = $"DELETE FROM Order WHERE id = {currentOrderId}";
            db.InsertRecord(query);
            orderPanel.Visible = false;
            editPanel.Visible = false;
            refreshOrdersList();
        }
    }
}


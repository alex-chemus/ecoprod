using Ecoprod.Helpers;
using Ecoprod.Views.ClientsView;
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

namespace Ecoprod.Views.ProductsView;

public partial class ProductsView : Form
{
    private DbHelper db;
    private int currentProductId;

    public ProductsView()
    {
        InitializeComponent();
        this.db = new DbHelper();
        productPanel.Visible = false;
        editPanel.Visible = false;
        if (UserState.getInstance().rank != Rank.Senior)
        {
            openEditButton.Visible = false;
            addPanel.Visible = false;
        }
    }

    private void refreshProductsList()
    {
        productsListView.Items.Clear();

        string query = $"SELECT * FROM Product";

        var table = db.getRecords(query);

        foreach (DataRow row in table.Rows)
        {
            var listItem = new ListViewItem(row["name"].ToString());
            listItem.Tag = row["id"].ToString();
            productsListView.Items.Add(listItem);
        }
    }

    private void ProductsView_Load(object sender, EventArgs e)
    {
        refreshProductsList();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var name = addNameTextbox.Text;
        var price = addPriceTextbox.Text;
        var description = addDescriptionTextbox.Text;

        string query = $"INSERT INTO Product (" +
            $"name, price, description" +
            $") VALUES (" +
            $"'{name}', {price}, '{description}')";

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка добавления товара");
        }

        addNameTextbox.Text = "";
        addPriceTextbox.Text = "";
        addDescriptionTextbox.Text = "";

        refreshProductsList();
    }

    private void productsListView_MouseClick(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < productsListView.Items.Count; i++)
        {
            var rect = productsListView.GetItemRect(i);
            if (rect.Contains(e.Location))
            {
                Debug.WriteLine(productsListView.Items[i].Tag);

                int productId = Int32.Parse(productsListView.Items[i].Tag.ToString());

                string query = $"SELECT * FROM Product WHERE id = {productId}";

                var row = db.getSignelRecord(query);

                productNameLabel.Text = row["name"].ToString();
                productPriceLabel.Text = "Цена: " + row["price"].ToString();
                productDescriptionTextbox.Text = row["description"].ToString();
                productDescriptionTextbox.Enabled = false;

                productPanel.Visible = true;

                currentProductId = productId;
            }
        }
    }

    private void openEditButton_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;

        string query = $"SELECT * FROM Product WHERE id = {currentProductId}";

        var row = db.getSignelRecord(query);

        editNameTextbox.Text = row["name"].ToString();
        editPriceTextbox.Text = row["price"].ToString();
        editDescriptionTextbox.Text = row["description"].ToString();

        productPanel.Visible = false;
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        var name = editNameTextbox.Text;
        var price = editPriceTextbox.Text;
        var description = editDescriptionTextbox.Text;

        string query = $"UPDATE Product SET " +
            $"name = '{name}', " +
            $"price = {price}, " +
            $"description = '{description}' " +
            $"WHERE id = {currentProductId}";

        Debug.WriteLine(query);

        try
        {
            db.InsertRecord(query);
        }
        catch
        {
            MessageBox.Show("Ошибка редактирования товара");
        }

        editPanel.Visible = false;

        refreshProductsList();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new ClientsView.ClientsView().Show();
        Hide();
    }

    private void requestsButton_Click(object sender, EventArgs e)
    {
        new RequestsView.RequestsView().Show();
        Hide();
    }

    private void ordersButton_Click(object sender, EventArgs e)
    {
        new OrdersView.OrdersView().Show();
        Hide();
    }
}


using Ecoprod.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ecoprod.Views.ClientsView;

namespace Ecoprod.Views.LoginView;

public partial class LoginView : Form
{
    private DbHelper db;

    public LoginView()
    {
        InitializeComponent();
        this.db = new DbHelper();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        var login = loginTextbox.Text;
        var loginValid = StringFormatter.Check("Логин", login, 20);

        var password = passwordTextbox.Text;
        var passwordValid = StringFormatter.Check("Пароль", password, 20);

        if (!loginValid || !passwordValid) return;

        string query = $"SELECT * FROM Manager WHERE " +
            $"login = '{login}' AND password = '{password}'";

        if (db.CountRecords(query) > 0)
        {
            var row = db.getSignelRecord(query);
            UserState.createInstance((int)row["id"], (Rank)row["rankId"]);
            new ClientsView.ClientsView().Show();
            this.Hide();
        }
    }
}


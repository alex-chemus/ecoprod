namespace Ecoprod.Views.ClientsView
{
    partial class ClientsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientsListview = new ListView();
            addPanel = new Panel();
            addButton = new Button();
            addEmailTextbox = new TextBox();
            addPhoneTextbox = new TextBox();
            addNameTextbox = new TextBox();
            label1 = new Label();
            clientPanel = new Panel();
            openEditButton = new Button();
            clientEmailLabel = new Label();
            clientPhoneLabel = new Label();
            clientNameLabel = new Label();
            editPanel = new Panel();
            editButton = new Button();
            editEmailTextbox = new TextBox();
            editPhoneTextbox = new TextBox();
            editNameTextbox = new TextBox();
            label2 = new Label();
            productsButton = new Button();
            requestsButton = new Button();
            ordersButton = new Button();
            addPanel.SuspendLayout();
            clientPanel.SuspendLayout();
            editPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientsListview
            // 
            clientsListview.Cursor = Cursors.Hand;
            clientsListview.Location = new Point(284, 68);
            clientsListview.Name = "clientsListview";
            clientsListview.Size = new Size(205, 187);
            clientsListview.TabIndex = 0;
            clientsListview.UseCompatibleStateImageBehavior = false;
            clientsListview.View = View.Tile;
            clientsListview.MouseClick += clientsListview_MouseClick;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(addEmailTextbox);
            addPanel.Controls.Add(addPhoneTextbox);
            addPanel.Controls.Add(addNameTextbox);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(31, 68);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(200, 187);
            addPanel.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(5, 122);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addEmailTextbox
            // 
            addEmailTextbox.Location = new Point(5, 93);
            addEmailTextbox.Name = "addEmailTextbox";
            addEmailTextbox.PlaceholderText = "Email";
            addEmailTextbox.Size = new Size(100, 23);
            addEmailTextbox.TabIndex = 3;
            // 
            // addPhoneTextbox
            // 
            addPhoneTextbox.Location = new Point(5, 64);
            addPhoneTextbox.Name = "addPhoneTextbox";
            addPhoneTextbox.PlaceholderText = "Телефон";
            addPhoneTextbox.Size = new Size(100, 23);
            addPhoneTextbox.TabIndex = 2;
            // 
            // addNameTextbox
            // 
            addNameTextbox.Location = new Point(5, 35);
            addNameTextbox.Name = "addNameTextbox";
            addNameTextbox.PlaceholderText = "Имя";
            addNameTextbox.Size = new Size(100, 23);
            addNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавить клиента";
            // 
            // clientPanel
            // 
            clientPanel.Controls.Add(openEditButton);
            clientPanel.Controls.Add(clientEmailLabel);
            clientPanel.Controls.Add(clientPhoneLabel);
            clientPanel.Controls.Add(clientNameLabel);
            clientPanel.Location = new Point(530, 68);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(200, 174);
            clientPanel.TabIndex = 2;
            // 
            // openEditButton
            // 
            openEditButton.Location = new Point(3, 80);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(111, 23);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // clientEmailLabel
            // 
            clientEmailLabel.AutoSize = true;
            clientEmailLabel.Location = new Point(3, 52);
            clientEmailLabel.Name = "clientEmailLabel";
            clientEmailLabel.Size = new Size(88, 15);
            clientEmailLabel.TabIndex = 2;
            clientEmailLabel.Text = "Почта клиента";
            // 
            // clientPhoneLabel
            // 
            clientPhoneLabel.AutoSize = true;
            clientPhoneLabel.Location = new Point(3, 24);
            clientPhoneLabel.Name = "clientPhoneLabel";
            clientPhoneLabel.Size = new Size(102, 15);
            clientPhoneLabel.TabIndex = 1;
            clientPhoneLabel.Text = "Телефон клиента";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new Point(3, 0);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(78, 15);
            clientNameLabel.TabIndex = 0;
            clientNameLabel.Text = "Имя клиента";
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editEmailTextbox);
            editPanel.Controls.Add(editPhoneTextbox);
            editPanel.Controls.Add(editNameTextbox);
            editPanel.Controls.Add(label2);
            editPanel.Location = new Point(287, 288);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(202, 156);
            editPanel.TabIndex = 3;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 114);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editEmailTextbox
            // 
            editEmailTextbox.Location = new Point(3, 85);
            editEmailTextbox.Name = "editEmailTextbox";
            editEmailTextbox.PlaceholderText = "Email";
            editEmailTextbox.Size = new Size(100, 23);
            editEmailTextbox.TabIndex = 3;
            // 
            // editPhoneTextbox
            // 
            editPhoneTextbox.Location = new Point(3, 56);
            editPhoneTextbox.Name = "editPhoneTextbox";
            editPhoneTextbox.PlaceholderText = "Телефон";
            editPhoneTextbox.Size = new Size(100, 23);
            editPhoneTextbox.TabIndex = 2;
            // 
            // editNameTextbox
            // 
            editNameTextbox.Location = new Point(3, 27);
            editNameTextbox.Name = "editNameTextbox";
            editNameTextbox.PlaceholderText = "Имя";
            editNameTextbox.Size = new Size(100, 23);
            editNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 0;
            label2.Text = "Редактировать клиента";
            // 
            // productsButton
            // 
            productsButton.Location = new Point(31, 23);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(75, 23);
            productsButton.TabIndex = 4;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.Location = new Point(112, 23);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(75, 23);
            requestsButton.TabIndex = 5;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = true;
            requestsButton.Click += requestsButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.Location = new Point(193, 23);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(75, 23);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // ClientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(ordersButton);
            Controls.Add(requestsButton);
            Controls.Add(productsButton);
            Controls.Add(editPanel);
            Controls.Add(clientPanel);
            Controls.Add(addPanel);
            Controls.Add(clientsListview);
            Name = "ClientsView";
            Text = "ClientsView";
            Load += ClientsView_Load;
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            clientPanel.ResumeLayout(false);
            clientPanel.PerformLayout();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView clientsListview;
        private Panel addPanel;
        private TextBox addNameTextbox;
        private Label label1;
        private Button addButton;
        private TextBox addEmailTextbox;
        private TextBox addPhoneTextbox;
        private Panel clientPanel;
        private Label clientEmailLabel;
        private Label clientPhoneLabel;
        private Label clientNameLabel;
        private Button openEditButton;
        private Panel editPanel;
        private Button editButton;
        private TextBox editEmailTextbox;
        private TextBox editPhoneTextbox;
        private TextBox editNameTextbox;
        private Label label2;
        private Button productsButton;
        private Button requestsButton;
        private Button ordersButton;
    }
}
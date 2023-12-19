namespace Ecoprod.Views.ProductsView
{
    partial class ProductsView
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
            editPanel = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            editButton = new Button();
            editDescriptionTextbox = new TextBox();
            editPriceTextbox = new TextBox();
            editNameTextbox = new TextBox();
            label2 = new Label();
            productPanel = new Panel();
            label6 = new Label();
            productDescriptionTextbox = new TextBox();
            openEditButton = new Button();
            productPriceLabel = new Label();
            productNameLabel = new Label();
            addPanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            addButton = new Button();
            addDescriptionTextbox = new TextBox();
            addPriceTextbox = new TextBox();
            addNameTextbox = new TextBox();
            label1 = new Label();
            productsListView = new ListView();
            clientsButton = new Button();
            ordersButton = new Button();
            requestsButton = new Button();
            productsButton = new Button();
            deleteButton = new Button();
            editPanel.SuspendLayout();
            productPanel.SuspendLayout();
            addPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(label9);
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(label7);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editDescriptionTextbox);
            editPanel.Controls.Add(editPriceTextbox);
            editPanel.Controls.Add(editNameTextbox);
            editPanel.Controls.Add(label2);
            editPanel.Location = new Point(624, 122);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(306, 365);
            editPanel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(3, 213);
            label9.Name = "label9";
            label9.Size = new Size(104, 26);
            label9.TabIndex = 9;
            label9.Text = "Описание";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 131);
            label8.Name = "label8";
            label8.Size = new Size(58, 26);
            label8.TabIndex = 8;
            label8.Text = "Цена";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 50);
            label7.Name = "label7";
            label7.Size = new Size(98, 26);
            label7.TabIndex = 7;
            label7.Text = "Название";
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.FromArgb(52, 152, 62);
            editButton.Location = new Point(0, 316);
            editButton.Name = "editButton";
            editButton.Size = new Size(131, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editDescriptionTextbox
            // 
            editDescriptionTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editDescriptionTextbox.Location = new Point(0, 242);
            editDescriptionTextbox.Multiline = true;
            editDescriptionTextbox.Name = "editDescriptionTextbox";
            editDescriptionTextbox.PlaceholderText = "Описание";
            editDescriptionTextbox.Size = new Size(306, 50);
            editDescriptionTextbox.TabIndex = 3;
            // 
            // editPriceTextbox
            // 
            editPriceTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editPriceTextbox.Location = new Point(0, 160);
            editPriceTextbox.Name = "editPriceTextbox";
            editPriceTextbox.PlaceholderText = "Цена";
            editPriceTextbox.Size = new Size(306, 30);
            editPriceTextbox.TabIndex = 2;
            // 
            // editNameTextbox
            // 
            editNameTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editNameTextbox.Location = new Point(0, 79);
            editNameTextbox.Name = "editNameTextbox";
            editNameTextbox.PlaceholderText = "Название";
            editNameTextbox.Size = new Size(306, 30);
            editNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(52, 152, 62);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(204, 27);
            label2.TabIndex = 0;
            label2.Text = "Редактировать товар";
            // 
            // productPanel
            // 
            productPanel.Controls.Add(deleteButton);
            productPanel.Controls.Add(label6);
            productPanel.Controls.Add(productDescriptionTextbox);
            productPanel.Controls.Add(openEditButton);
            productPanel.Controls.Add(productPriceLabel);
            productPanel.Controls.Add(productNameLabel);
            productPanel.Location = new Point(295, 465);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(306, 278);
            productPanel.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(104, 26);
            label6.TabIndex = 5;
            label6.Text = "Описание";
            // 
            // productDescriptionTextbox
            // 
            productDescriptionTextbox.BackColor = Color.White;
            productDescriptionTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productDescriptionTextbox.ForeColor = Color.Black;
            productDescriptionTextbox.Location = new Point(0, 119);
            productDescriptionTextbox.Multiline = true;
            productDescriptionTextbox.Name = "productDescriptionTextbox";
            productDescriptionTextbox.Size = new Size(306, 108);
            productDescriptionTextbox.TabIndex = 4;
            // 
            // openEditButton
            // 
            openEditButton.AutoSize = true;
            openEditButton.FlatStyle = FlatStyle.Flat;
            openEditButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openEditButton.ForeColor = Color.FromArgb(52, 152, 62);
            openEditButton.Location = new Point(0, 243);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(131, 35);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productPriceLabel.Location = new Point(3, 47);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(58, 26);
            productPriceLabel.TabIndex = 1;
            productPriceLabel.Text = "Цена";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = Color.White;
            productNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productNameLabel.ForeColor = Color.FromArgb(52, 152, 62);
            productNameLabel.Location = new Point(3, 3);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(164, 26);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Название товара";
            // 
            // addPanel
            // 
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(addDescriptionTextbox);
            addPanel.Controls.Add(addPriceTextbox);
            addPanel.Controls.Add(addNameTextbox);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(33, 122);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(236, 380);
            addPanel.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 214);
            label5.Name = "label5";
            label5.Size = new Size(104, 26);
            label5.TabIndex = 8;
            label5.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 131);
            label4.Name = "label4";
            label4.Size = new Size(58, 26);
            label4.TabIndex = 7;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 6;
            label3.Text = "Название";
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = Color.White;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.FromArgb(52, 152, 62);
            addButton.Location = new Point(0, 343);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // addDescriptionTextbox
            // 
            addDescriptionTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addDescriptionTextbox.Location = new Point(1, 243);
            addDescriptionTextbox.Multiline = true;
            addDescriptionTextbox.Name = "addDescriptionTextbox";
            addDescriptionTextbox.PlaceholderText = "Описание";
            addDescriptionTextbox.Size = new Size(235, 80);
            addDescriptionTextbox.TabIndex = 3;
            // 
            // addPriceTextbox
            // 
            addPriceTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addPriceTextbox.Location = new Point(0, 160);
            addPriceTextbox.Name = "addPriceTextbox";
            addPriceTextbox.PlaceholderText = "Цена";
            addPriceTextbox.Size = new Size(236, 30);
            addPriceTextbox.TabIndex = 2;
            // 
            // addNameTextbox
            // 
            addNameTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNameTextbox.Location = new Point(0, 76);
            addNameTextbox.Name = "addNameTextbox";
            addNameTextbox.PlaceholderText = "Название";
            addNameTextbox.Size = new Size(236, 30);
            addNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 152, 62);
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(158, 27);
            label1.TabIndex = 0;
            label1.Text = "Добавить товар";
            // 
            // productsListView
            // 
            productsListView.Cursor = Cursors.Hand;
            productsListView.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsListView.Location = new Point(295, 122);
            productsListView.Name = "productsListView";
            productsListView.Size = new Size(306, 323);
            productsListView.TabIndex = 4;
            productsListView.UseCompatibleStateImageBehavior = false;
            productsListView.View = View.Tile;
            productsListView.MouseClick += productsListView_MouseClick;
            // 
            // clientsButton
            // 
            clientsButton.AutoSize = true;
            clientsButton.BackColor = Color.White;
            clientsButton.Cursor = Cursors.Hand;
            clientsButton.FlatStyle = FlatStyle.Flat;
            clientsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientsButton.ForeColor = Color.FromArgb(52, 152, 62);
            clientsButton.Location = new Point(33, 28);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(92, 35);
            clientsButton.TabIndex = 11;
            clientsButton.Text = "Клиенты";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += button1_Click;
            // 
            // ordersButton
            // 
            ordersButton.AutoSize = true;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ordersButton.ForeColor = Color.FromArgb(52, 152, 62);
            ordersButton.Location = new Point(295, 28);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(76, 35);
            ordersButton.TabIndex = 10;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.AutoSize = true;
            requestsButton.Cursor = Cursors.Hand;
            requestsButton.FlatStyle = FlatStyle.Flat;
            requestsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsButton.ForeColor = Color.FromArgb(52, 152, 62);
            requestsButton.Location = new Point(215, 28);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(75, 35);
            requestsButton.TabIndex = 9;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = true;
            requestsButton.Click += requestsButton_Click;
            // 
            // productsButton
            // 
            productsButton.AutoSize = true;
            productsButton.BackColor = Color.FromArgb(118, 227, 131);
            productsButton.Cursor = Cursors.Hand;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsButton.ForeColor = Color.White;
            productsButton.Location = new Point(129, 28);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(80, 35);
            productsButton.TabIndex = 8;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.FromArgb(52, 152, 62);
            deleteButton.Location = new Point(172, 240);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(131, 35);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 827);
            Controls.Add(addPanel);
            Controls.Add(clientsButton);
            Controls.Add(ordersButton);
            Controls.Add(requestsButton);
            Controls.Add(productsButton);
            Controls.Add(editPanel);
            Controls.Add(productPanel);
            Controls.Add(productsListView);
            Name = "ProductsView";
            Text = "ProductsView";
            Load += ProductsView_Load;
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            productPanel.ResumeLayout(false);
            productPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel editPanel;
        private Button editButton;
        private TextBox editDescriptionTextbox;
        private TextBox editPriceTextbox;
        private TextBox editNameTextbox;
        private Label label2;
        private Panel productPanel;
        private Button openEditButton;
        private Label productPriceLabel;
        private Label productNameLabel;
        private Panel addPanel;
        private Button addButton;
        private TextBox addDescriptionTextbox;
        private TextBox addPriceTextbox;
        private TextBox addNameTextbox;
        private Label label1;
        private ListView productsListView;
        private TextBox productDescriptionTextbox;
        private Button clientsButton;
        private Button ordersButton;
        private Button requestsButton;
        private Button productsButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Button deleteButton;
    }
}
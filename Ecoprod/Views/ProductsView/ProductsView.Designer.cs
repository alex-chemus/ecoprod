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
            editButton = new Button();
            editDescriptionTextbox = new TextBox();
            editPriceTextbox = new TextBox();
            editNameTextbox = new TextBox();
            label2 = new Label();
            productPanel = new Panel();
            productDescriptionTextbox = new TextBox();
            openEditButton = new Button();
            productPriceLabel = new Label();
            productNameLabel = new Label();
            addPanel = new Panel();
            addButton = new Button();
            addDescriptionTextbox = new TextBox();
            addPriceTextbox = new TextBox();
            addNameTextbox = new TextBox();
            label1 = new Label();
            productsListView = new ListView();
            editPanel.SuspendLayout();
            productPanel.SuspendLayout();
            addPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editDescriptionTextbox);
            editPanel.Controls.Add(editPriceTextbox);
            editPanel.Controls.Add(editNameTextbox);
            editPanel.Controls.Add(label2);
            editPanel.Location = new Point(307, 257);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(202, 181);
            editPanel.TabIndex = 7;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 141);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editDescriptionTextbox
            // 
            editDescriptionTextbox.Location = new Point(3, 85);
            editDescriptionTextbox.Multiline = true;
            editDescriptionTextbox.Name = "editDescriptionTextbox";
            editDescriptionTextbox.PlaceholderText = "Описание";
            editDescriptionTextbox.Size = new Size(196, 50);
            editDescriptionTextbox.TabIndex = 3;
            // 
            // editPriceTextbox
            // 
            editPriceTextbox.Location = new Point(3, 56);
            editPriceTextbox.Name = "editPriceTextbox";
            editPriceTextbox.PlaceholderText = "Цена";
            editPriceTextbox.Size = new Size(100, 23);
            editPriceTextbox.TabIndex = 2;
            // 
            // editNameTextbox
            // 
            editNameTextbox.Location = new Point(3, 27);
            editNameTextbox.Name = "editNameTextbox";
            editNameTextbox.PlaceholderText = "Название";
            editNameTextbox.Size = new Size(100, 23);
            editNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 0;
            label2.Text = "Редактировать товар";
            // 
            // productPanel
            // 
            productPanel.Controls.Add(productDescriptionTextbox);
            productPanel.Controls.Add(openEditButton);
            productPanel.Controls.Add(productPriceLabel);
            productPanel.Controls.Add(productNameLabel);
            productPanel.Location = new Point(550, 37);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(200, 174);
            productPanel.TabIndex = 6;
            // 
            // productDescriptionTextbox
            // 
            productDescriptionTextbox.Location = new Point(3, 53);
            productDescriptionTextbox.Multiline = true;
            productDescriptionTextbox.Name = "productDescriptionTextbox";
            productDescriptionTextbox.Size = new Size(192, 47);
            productDescriptionTextbox.TabIndex = 4;
            // 
            // openEditButton
            // 
            openEditButton.Location = new Point(3, 113);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(111, 23);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new Point(3, 24);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(75, 15);
            productPriceLabel.TabIndex = 1;
            productPriceLabel.Text = "Цена товара";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(3, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(99, 15);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Название товара";
            // 
            // addPanel
            // 
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(addDescriptionTextbox);
            addPanel.Controls.Add(addPriceTextbox);
            addPanel.Controls.Add(addNameTextbox);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(51, 37);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(200, 187);
            addPanel.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(5, 142);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addDescriptionTextbox
            // 
            addDescriptionTextbox.Location = new Point(5, 93);
            addDescriptionTextbox.Multiline = true;
            addDescriptionTextbox.Name = "addDescriptionTextbox";
            addDescriptionTextbox.PlaceholderText = "Email";
            addDescriptionTextbox.Size = new Size(181, 43);
            addDescriptionTextbox.TabIndex = 3;
            // 
            // addPriceTextbox
            // 
            addPriceTextbox.Location = new Point(5, 64);
            addPriceTextbox.Name = "addPriceTextbox";
            addPriceTextbox.PlaceholderText = "Цена";
            addPriceTextbox.Size = new Size(100, 23);
            addPriceTextbox.TabIndex = 2;
            // 
            // addNameTextbox
            // 
            addNameTextbox.Location = new Point(5, 35);
            addNameTextbox.Name = "addNameTextbox";
            addNameTextbox.PlaceholderText = "Название";
            addNameTextbox.Size = new Size(100, 23);
            addNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавить товар";
            // 
            // productsListView
            // 
            productsListView.Cursor = Cursors.Hand;
            productsListView.Location = new Point(304, 37);
            productsListView.Name = "productsListView";
            productsListView.Size = new Size(205, 187);
            productsListView.TabIndex = 4;
            productsListView.UseCompatibleStateImageBehavior = false;
            productsListView.View = View.Tile;
            productsListView.MouseClick += productsListView_MouseClick;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editPanel);
            Controls.Add(productPanel);
            Controls.Add(addPanel);
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
    }
}
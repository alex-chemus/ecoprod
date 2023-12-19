namespace Ecoprod.Views.RequestsView
{
    partial class RequestsView
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
            editCreationDatePicker = new DateTimePicker();
            editButton = new Button();
            editAmountNumeric = new NumericUpDown();
            label2 = new Label();
            editClientCombobox = new ComboBox();
            editProductCombobox = new ComboBox();
            requestPanel = new Panel();
            clientNameLabel = new Label();
            creationDateLabel = new Label();
            amountLabel = new Label();
            openEditButton = new Button();
            productNameLabel = new Label();
            addPanel = new Panel();
            addCreationDatePicker = new DateTimePicker();
            addAmountNumeric = new NumericUpDown();
            addClientCombobox = new ComboBox();
            addProductCombobox = new ComboBox();
            addButton = new Button();
            label1 = new Label();
            requestsListView = new ListView();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editAmountNumeric).BeginInit();
            requestPanel.SuspendLayout();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editCreationDatePicker);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editAmountNumeric);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(editClientCombobox);
            editPanel.Controls.Add(editProductCombobox);
            editPanel.Location = new Point(304, 248);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(202, 249);
            editPanel.TabIndex = 11;
            editPanel.Visible = false;
            // 
            // editCreationDatePicker
            // 
            editCreationDatePicker.Location = new Point(7, 151);
            editCreationDatePicker.Name = "editCreationDatePicker";
            editCreationDatePicker.Size = new Size(121, 23);
            editCreationDatePicker.TabIndex = 15;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 191);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editAmountNumeric
            // 
            editAmountNumeric.Location = new Point(7, 117);
            editAmountNumeric.Name = "editAmountNumeric";
            editAmountNumeric.Size = new Size(120, 23);
            editAmountNumeric.TabIndex = 14;
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
            // editClientCombobox
            // 
            editClientCombobox.FormattingEnabled = true;
            editClientCombobox.Location = new Point(7, 79);
            editClientCombobox.Name = "editClientCombobox";
            editClientCombobox.Size = new Size(121, 23);
            editClientCombobox.TabIndex = 13;
            // 
            // editProductCombobox
            // 
            editProductCombobox.FormattingEnabled = true;
            editProductCombobox.Location = new Point(7, 42);
            editProductCombobox.Name = "editProductCombobox";
            editProductCombobox.Size = new Size(121, 23);
            editProductCombobox.TabIndex = 12;
            // 
            // requestPanel
            // 
            requestPanel.Controls.Add(clientNameLabel);
            requestPanel.Controls.Add(creationDateLabel);
            requestPanel.Controls.Add(amountLabel);
            requestPanel.Controls.Add(openEditButton);
            requestPanel.Controls.Add(productNameLabel);
            requestPanel.Location = new Point(550, 25);
            requestPanel.Name = "requestPanel";
            requestPanel.Size = new Size(200, 170);
            requestPanel.TabIndex = 10;
            requestPanel.Visible = false;
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new Point(3, 102);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(106, 15);
            clientNameLabel.TabIndex = 6;
            clientNameLabel.Text = "Название клиента";
            // 
            // creationDateLabel
            // 
            creationDateLabel.AutoSize = true;
            creationDateLabel.Location = new Point(3, 77);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new Size(85, 15);
            creationDateLabel.TabIndex = 5;
            creationDateLabel.Text = "Дата создания";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(3, 48);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(112, 15);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Количество товара";
            // 
            // openEditButton
            // 
            openEditButton.Location = new Point(3, 135);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(111, 23);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(3, 24);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(99, 15);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Название товара";
            // 
            // addPanel
            // 
            addPanel.Controls.Add(addCreationDatePicker);
            addPanel.Controls.Add(addAmountNumeric);
            addPanel.Controls.Add(addClientCombobox);
            addPanel.Controls.Add(addProductCombobox);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(51, 25);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(200, 244);
            addPanel.TabIndex = 9;
            // 
            // addCreationDatePicker
            // 
            addCreationDatePicker.Location = new Point(8, 147);
            addCreationDatePicker.Name = "addCreationDatePicker";
            addCreationDatePicker.Size = new Size(121, 23);
            addCreationDatePicker.TabIndex = 8;
            // 
            // addAmountNumeric
            // 
            addAmountNumeric.Location = new Point(8, 115);
            addAmountNumeric.Name = "addAmountNumeric";
            addAmountNumeric.Size = new Size(120, 23);
            addAmountNumeric.TabIndex = 7;
            // 
            // addClientCombobox
            // 
            addClientCombobox.FormattingEnabled = true;
            addClientCombobox.Location = new Point(8, 77);
            addClientCombobox.Name = "addClientCombobox";
            addClientCombobox.Size = new Size(121, 23);
            addClientCombobox.TabIndex = 6;
            // 
            // addProductCombobox
            // 
            addProductCombobox.FlatStyle = FlatStyle.Flat;
            addProductCombobox.FormattingEnabled = true;
            addProductCombobox.Location = new Point(8, 40);
            addProductCombobox.Name = "addProductCombobox";
            addProductCombobox.Size = new Size(121, 23);
            addProductCombobox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(8, 185);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавить заявку";
            // 
            // requestsListView
            // 
            requestsListView.Cursor = Cursors.Hand;
            requestsListView.Location = new Point(304, 25);
            requestsListView.Name = "requestsListView";
            requestsListView.Size = new Size(205, 187);
            requestsListView.TabIndex = 8;
            requestsListView.UseCompatibleStateImageBehavior = false;
            requestsListView.View = View.Tile;
            requestsListView.MouseClick += requestsListView_MouseClick;
            // 
            // RequestsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(editPanel);
            Controls.Add(requestPanel);
            Controls.Add(addPanel);
            Controls.Add(requestsListView);
            Name = "RequestsView";
            Text = "RequestsView";
            Load += RequestsView_Load;
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editAmountNumeric).EndInit();
            requestPanel.ResumeLayout(false);
            requestPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel editPanel;
        private Button editButton;
        private Label label2;
        private Panel requestPanel;
        private TextBox productDescriptionTextbox;
        private Button openEditButton;
        private Label productPriceLabel;
        private Label productNameLabel;
        private Panel addPanel;
        private Button addButton;
        private TextBox addDescriptionTextbox;
        private TextBox addPriceTextbox;
        private TextBox addNameTextbox;
        private Label label1;
        private ListView requestsListView;
        private DateTimePicker addCreationDatePicker;
        private NumericUpDown addAmountNumeric;
        private ComboBox addClientCombobox;
        private ComboBox addProductCombobox;
        private Label creationDateLabel;
        private Label amountLabel;
        private DateTimePicker editCreationDatePicker;
        private NumericUpDown editAmountNumeric;
        private ComboBox editClientCombobox;
        private ComboBox editProductCombobox;
        private Label clientNameLabel;
    }
}
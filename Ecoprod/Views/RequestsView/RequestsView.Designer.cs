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
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            addCreationDatePicker = new DateTimePicker();
            addAmountNumeric = new NumericUpDown();
            addClientCombobox = new ComboBox();
            addProductCombobox = new ComboBox();
            addButton = new Button();
            label1 = new Label();
            requestsListView = new ListView();
            clientsButton = new Button();
            ordersButton = new Button();
            requestsButton = new Button();
            productsButton = new Button();
            deleteButton = new Button();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editAmountNumeric).BeginInit();
            requestPanel.SuspendLayout();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(label10);
            editPanel.Controls.Add(label9);
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(label7);
            editPanel.Controls.Add(editCreationDatePicker);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editAmountNumeric);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(editClientCombobox);
            editPanel.Controls.Add(editProductCombobox);
            editPanel.Location = new Point(594, 118);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(266, 427);
            editPanel.TabIndex = 11;
            editPanel.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(3, 304);
            label10.Name = "label10";
            label10.Size = new Size(145, 26);
            label10.TabIndex = 19;
            label10.Text = "Дата создания";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(3, 218);
            label9.Name = "label9";
            label9.Size = new Size(119, 26);
            label9.TabIndex = 18;
            label9.Text = "Количество";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 132);
            label8.Name = "label8";
            label8.Size = new Size(78, 26);
            label8.TabIndex = 17;
            label8.Text = "Клиент";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 46);
            label7.Name = "label7";
            label7.Size = new Size(66, 26);
            label7.TabIndex = 16;
            label7.Text = "Товар";
            // 
            // editCreationDatePicker
            // 
            editCreationDatePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editCreationDatePicker.Location = new Point(0, 335);
            editCreationDatePicker.Name = "editCreationDatePicker";
            editCreationDatePicker.Size = new Size(265, 30);
            editCreationDatePicker.TabIndex = 15;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.FromArgb(52, 152, 62);
            editButton.Location = new Point(3, 392);
            editButton.Name = "editButton";
            editButton.Size = new Size(131, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editAmountNumeric
            // 
            editAmountNumeric.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editAmountNumeric.Location = new Point(0, 247);
            editAmountNumeric.Name = "editAmountNumeric";
            editAmountNumeric.Size = new Size(122, 30);
            editAmountNumeric.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(52, 152, 62);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(205, 26);
            label2.TabIndex = 0;
            label2.Text = "Редактировать заявку";
            // 
            // editClientCombobox
            // 
            editClientCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editClientCombobox.FormattingEnabled = true;
            editClientCombobox.Location = new Point(0, 161);
            editClientCombobox.Name = "editClientCombobox";
            editClientCombobox.Size = new Size(266, 31);
            editClientCombobox.TabIndex = 13;
            // 
            // editProductCombobox
            // 
            editProductCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editProductCombobox.FormattingEnabled = true;
            editProductCombobox.Location = new Point(0, 75);
            editProductCombobox.Name = "editProductCombobox";
            editProductCombobox.Size = new Size(266, 31);
            editProductCombobox.TabIndex = 12;
            // 
            // requestPanel
            // 
            requestPanel.Controls.Add(deleteButton);
            requestPanel.Controls.Add(clientNameLabel);
            requestPanel.Controls.Add(creationDateLabel);
            requestPanel.Controls.Add(amountLabel);
            requestPanel.Controls.Add(openEditButton);
            requestPanel.Controls.Add(productNameLabel);
            requestPanel.Location = new Point(308, 325);
            requestPanel.Name = "requestPanel";
            requestPanel.Size = new Size(253, 220);
            requestPanel.TabIndex = 10;
            requestPanel.Visible = false;
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientNameLabel.Location = new Point(3, 87);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(177, 26);
            clientNameLabel.TabIndex = 6;
            clientNameLabel.Text = "Название клиента";
            // 
            // creationDateLabel
            // 
            creationDateLabel.AutoSize = true;
            creationDateLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            creationDateLabel.Location = new Point(3, 133);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new Size(145, 26);
            creationDateLabel.TabIndex = 5;
            creationDateLabel.Text = "Дата создания";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(3, 42);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(119, 26);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Количество";
            // 
            // openEditButton
            // 
            openEditButton.AutoSize = true;
            openEditButton.FlatStyle = FlatStyle.Flat;
            openEditButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openEditButton.ForeColor = Color.FromArgb(52, 152, 62);
            openEditButton.Location = new Point(0, 183);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(131, 35);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productNameLabel.ForeColor = Color.FromArgb(52, 152, 62);
            productNameLabel.Location = new Point(3, 3);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(164, 26);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Название товара";
            // 
            // addPanel
            // 
            addPanel.Controls.Add(label6);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Controls.Add(addCreationDatePicker);
            addPanel.Controls.Add(addAmountNumeric);
            addPanel.Controls.Add(addClientCombobox);
            addPanel.Controls.Add(addProductCombobox);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(34, 118);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(242, 427);
            addPanel.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 304);
            label6.Name = "label6";
            label6.Size = new Size(145, 26);
            label6.TabIndex = 12;
            label6.Text = "Дата создания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 218);
            label5.Name = "label5";
            label5.Size = new Size(119, 26);
            label5.TabIndex = 11;
            label5.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(78, 26);
            label4.TabIndex = 10;
            label4.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(66, 26);
            label3.TabIndex = 9;
            label3.Text = "Товар";
            // 
            // addCreationDatePicker
            // 
            addCreationDatePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addCreationDatePicker.Location = new Point(3, 335);
            addCreationDatePicker.Name = "addCreationDatePicker";
            addCreationDatePicker.Size = new Size(239, 30);
            addCreationDatePicker.TabIndex = 8;
            // 
            // addAmountNumeric
            // 
            addAmountNumeric.BorderStyle = BorderStyle.FixedSingle;
            addAmountNumeric.Cursor = Cursors.IBeam;
            addAmountNumeric.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addAmountNumeric.Location = new Point(0, 247);
            addAmountNumeric.Name = "addAmountNumeric";
            addAmountNumeric.Size = new Size(122, 30);
            addAmountNumeric.TabIndex = 7;
            // 
            // addClientCombobox
            // 
            addClientCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addClientCombobox.FormattingEnabled = true;
            addClientCombobox.Location = new Point(0, 161);
            addClientCombobox.Name = "addClientCombobox";
            addClientCombobox.Size = new Size(242, 31);
            addClientCombobox.TabIndex = 6;
            // 
            // addProductCombobox
            // 
            addProductCombobox.BackColor = Color.White;
            addProductCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addProductCombobox.ForeColor = SystemColors.WindowText;
            addProductCombobox.FormattingEnabled = true;
            addProductCombobox.Location = new Point(0, 75);
            addProductCombobox.Name = "addProductCombobox";
            addProductCombobox.Size = new Size(242, 31);
            addProductCombobox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.FromArgb(52, 152, 62);
            addButton.Location = new Point(0, 390);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 152, 62);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(161, 26);
            label1.TabIndex = 0;
            label1.Text = "Добавить заявку";
            // 
            // requestsListView
            // 
            requestsListView.Cursor = Cursors.Hand;
            requestsListView.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsListView.Location = new Point(308, 114);
            requestsListView.Name = "requestsListView";
            requestsListView.Size = new Size(253, 187);
            requestsListView.TabIndex = 8;
            requestsListView.UseCompatibleStateImageBehavior = false;
            requestsListView.View = View.Tile;
            requestsListView.MouseClick += requestsListView_MouseClick;
            // 
            // clientsButton
            // 
            clientsButton.AutoSize = true;
            clientsButton.BackColor = Color.White;
            clientsButton.Cursor = Cursors.Hand;
            clientsButton.FlatStyle = FlatStyle.Flat;
            clientsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientsButton.ForeColor = Color.FromArgb(52, 152, 62);
            clientsButton.Location = new Point(34, 26);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(92, 35);
            clientsButton.TabIndex = 15;
            clientsButton.Text = "Клиенты";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.AutoSize = true;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ordersButton.ForeColor = Color.FromArgb(52, 152, 62);
            ordersButton.Location = new Point(296, 26);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(76, 35);
            ordersButton.TabIndex = 14;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.AutoSize = true;
            requestsButton.BackColor = Color.FromArgb(118, 227, 131);
            requestsButton.Cursor = Cursors.Hand;
            requestsButton.FlatStyle = FlatStyle.Flat;
            requestsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsButton.ForeColor = Color.White;
            requestsButton.Location = new Point(216, 26);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(75, 35);
            requestsButton.TabIndex = 13;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = false;
            // 
            // productsButton
            // 
            productsButton.AutoSize = true;
            productsButton.Cursor = Cursors.Hand;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsButton.ForeColor = Color.FromArgb(52, 152, 62);
            productsButton.Location = new Point(130, 26);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(80, 35);
            productsButton.TabIndex = 12;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.FromArgb(52, 152, 62);
            deleteButton.Location = new Point(165, 182);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 35);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // RequestsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 786);
            Controls.Add(clientsButton);
            Controls.Add(ordersButton);
            Controls.Add(requestsButton);
            Controls.Add(productsButton);
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
            PerformLayout();
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
        private Button clientsButton;
        private Button ordersButton;
        private Button requestsButton;
        private Button productsButton;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button deleteButton;
    }
}
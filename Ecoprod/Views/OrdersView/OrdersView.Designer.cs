namespace Ecoprod.Views.OrdersView
{
    partial class OrdersView
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
            editManagerCombobox = new ComboBox();
            editDeadlinePicker = new DateTimePicker();
            editCreationDatePicker = new DateTimePicker();
            editButton = new Button();
            label2 = new Label();
            editStatusCombobox = new ComboBox();
            orderPanel = new Panel();
            managerNameLabel = new Label();
            deadlineLabel = new Label();
            clientNameLabel = new Label();
            creationDateLabel = new Label();
            amountLabel = new Label();
            openEditButton = new Button();
            productNameLabel = new Label();
            addPanel = new Panel();
            addDeadlinePicker = new DateTimePicker();
            addIdCombobox = new ComboBox();
            addCreationDatePicker = new DateTimePicker();
            addStatusCombobox = new ComboBox();
            addManagerCombobox = new ComboBox();
            addButton = new Button();
            label1 = new Label();
            ordersListView = new ListView();
            editPanel.SuspendLayout();
            orderPanel.SuspendLayout();
            addPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editManagerCombobox);
            editPanel.Controls.Add(editDeadlinePicker);
            editPanel.Controls.Add(editCreationDatePicker);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(editStatusCombobox);
            editPanel.Location = new Point(295, 270);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(202, 249);
            editPanel.TabIndex = 15;
            editPanel.Visible = false;
            // 
            // editManagerCombobox
            // 
            editManagerCombobox.FormattingEnabled = true;
            editManagerCombobox.Location = new Point(7, 80);
            editManagerCombobox.Name = "editManagerCombobox";
            editManagerCombobox.Size = new Size(121, 23);
            editManagerCombobox.TabIndex = 16;
            // 
            // editDeadlinePicker
            // 
            editDeadlinePicker.Location = new Point(7, 114);
            editDeadlinePicker.Name = "editDeadlinePicker";
            editDeadlinePicker.Size = new Size(121, 23);
            editDeadlinePicker.TabIndex = 11;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 0;
            label2.Text = "Редактировать заказ";
            // 
            // editStatusCombobox
            // 
            editStatusCombobox.FormattingEnabled = true;
            editStatusCombobox.Location = new Point(7, 42);
            editStatusCombobox.Name = "editStatusCombobox";
            editStatusCombobox.Size = new Size(121, 23);
            editStatusCombobox.TabIndex = 12;
            // 
            // orderPanel
            // 
            orderPanel.Controls.Add(managerNameLabel);
            orderPanel.Controls.Add(deadlineLabel);
            orderPanel.Controls.Add(clientNameLabel);
            orderPanel.Controls.Add(creationDateLabel);
            orderPanel.Controls.Add(amountLabel);
            orderPanel.Controls.Add(openEditButton);
            orderPanel.Controls.Add(productNameLabel);
            orderPanel.Location = new Point(541, 47);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(200, 256);
            orderPanel.TabIndex = 14;
            orderPanel.Visible = false;
            // 
            // managerNameLabel
            // 
            managerNameLabel.AutoSize = true;
            managerNameLabel.Location = new Point(7, 147);
            managerNameLabel.Name = "managerNameLabel";
            managerNameLabel.Size = new Size(150, 15);
            managerNameLabel.TabIndex = 8;
            managerNameLabel.Text = "Ответственный менеджер";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Location = new Point(3, 123);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(84, 15);
            deadlineLabel.TabIndex = 7;
            deadlineLabel.Text = "Крайний срок";
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
            openEditButton.Location = new Point(4, 174);
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
            addPanel.Controls.Add(addDeadlinePicker);
            addPanel.Controls.Add(addIdCombobox);
            addPanel.Controls.Add(addCreationDatePicker);
            addPanel.Controls.Add(addStatusCombobox);
            addPanel.Controls.Add(addManagerCombobox);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(42, 47);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(200, 288);
            addPanel.TabIndex = 13;
            // 
            // addDeadlinePicker
            // 
            addDeadlinePicker.Location = new Point(8, 150);
            addDeadlinePicker.Name = "addDeadlinePicker";
            addDeadlinePicker.Size = new Size(121, 23);
            addDeadlinePicker.TabIndex = 10;
            // 
            // addIdCombobox
            // 
            addIdCombobox.FormattingEnabled = true;
            addIdCombobox.Location = new Point(8, 48);
            addIdCombobox.Name = "addIdCombobox";
            addIdCombobox.Size = new Size(121, 23);
            addIdCombobox.TabIndex = 9;
            // 
            // addCreationDatePicker
            // 
            addCreationDatePicker.Location = new Point(8, 185);
            addCreationDatePicker.Name = "addCreationDatePicker";
            addCreationDatePicker.Size = new Size(121, 23);
            addCreationDatePicker.TabIndex = 8;
            // 
            // addStatusCombobox
            // 
            addStatusCombobox.FormattingEnabled = true;
            addStatusCombobox.Location = new Point(8, 77);
            addStatusCombobox.Name = "addStatusCombobox";
            addStatusCombobox.Size = new Size(121, 23);
            addStatusCombobox.TabIndex = 6;
            // 
            // addManagerCombobox
            // 
            addManagerCombobox.FlatStyle = FlatStyle.Flat;
            addManagerCombobox.FormattingEnabled = true;
            addManagerCombobox.Location = new Point(8, 110);
            addManagerCombobox.Name = "addManagerCombobox";
            addManagerCombobox.Size = new Size(121, 23);
            addManagerCombobox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(8, 222);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Создать";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Создать заказ";
            // 
            // ordersListView
            // 
            ordersListView.Cursor = Cursors.Hand;
            ordersListView.Location = new Point(295, 47);
            ordersListView.Name = "ordersListView";
            ordersListView.Size = new Size(205, 187);
            ordersListView.TabIndex = 12;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Tile;
            ordersListView.MouseClick += ordersListView_MouseClick;
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(editPanel);
            Controls.Add(orderPanel);
            Controls.Add(addPanel);
            Controls.Add(ordersListView);
            Name = "OrdersView";
            Text = "OrdersView";
            Load += OrdersView_Load;
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            orderPanel.ResumeLayout(false);
            orderPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel editPanel;
        private DateTimePicker editCreationDatePicker;
        private Button editButton;
        private NumericUpDown editAmountNumeric;
        private Label label2;
        private ComboBox editClientCombobox;
        private ComboBox editStatusCombobox;
        private Panel orderPanel;
        private Label managerNameLabel;
        private Label deadlineLabel;
        private Label clientNameLabel;
        private Label creationDateLabel;
        private Label amountLabel;
        private Button openEditButton;
        private Label productNameLabel;
        private Panel addPanel;
        private DateTimePicker addDeadlinePicker;
        private ComboBox addIdCombobox;
        private DateTimePicker addCreationDatePicker;
        private ComboBox addStatusCombobox;
        private ComboBox addManagerCombobox;
        private Button addButton;
        private Label label1;
        private ListView ordersListView;
        private DateTimePicker editDeadlinePicker;
        private ComboBox editManagerCombobox;
    }
}
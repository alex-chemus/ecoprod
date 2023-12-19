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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersView));
            editPanel = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            editManagerCombobox = new ComboBox();
            editDeadlinePicker = new DateTimePicker();
            editCreationDatePicker = new DateTimePicker();
            editButton = new Button();
            label2 = new Label();
            editStatusCombobox = new ComboBox();
            orderPanel = new Panel();
            deleteButton = new Button();
            managerNameLabel = new Label();
            deadlineLabel = new Label();
            clientNameLabel = new Label();
            creationDateLabel = new Label();
            amountLabel = new Label();
            openEditButton = new Button();
            productNameLabel = new Label();
            addPanel = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            addDeadlinePicker = new DateTimePicker();
            addIdCombobox = new ComboBox();
            addCreationDatePicker = new DateTimePicker();
            addStatusCombobox = new ComboBox();
            addManagerCombobox = new ComboBox();
            addButton = new Button();
            label1 = new Label();
            ordersListView = new ListView();
            clientsButton = new Button();
            ordersButton = new Button();
            requestsButton = new Button();
            productsButton = new Button();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            editPanel.SuspendLayout();
            orderPanel.SuspendLayout();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Controls.Add(label11);
            editPanel.Controls.Add(label10);
            editPanel.Controls.Add(label9);
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(editManagerCombobox);
            editPanel.Controls.Add(editDeadlinePicker);
            editPanel.Controls.Add(editCreationDatePicker);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(editStatusCombobox);
            editPanel.Location = new Point(653, 117);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(314, 521);
            editPanel.TabIndex = 15;
            editPanel.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(3, 310);
            label11.Name = "label11";
            label11.Size = new Size(163, 26);
            label11.TabIndex = 20;
            label11.Text = " Дата окончания";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(3, 137);
            label10.Name = "label10";
            label10.Size = new Size(104, 26);
            label10.TabIndex = 19;
            label10.Text = "Менеджер";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(3, 51);
            label9.Name = "label9";
            label9.Size = new Size(71, 26);
            label9.TabIndex = 18;
            label9.Text = "Статус";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 227);
            label8.Name = "label8";
            label8.Size = new Size(151, 26);
            label8.TabIndex = 17;
            label8.Text = " Дата создания";
            // 
            // editManagerCombobox
            // 
            editManagerCombobox.Cursor = Cursors.Hand;
            editManagerCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editManagerCombobox.FormattingEnabled = true;
            editManagerCombobox.Location = new Point(0, 166);
            editManagerCombobox.Name = "editManagerCombobox";
            editManagerCombobox.Size = new Size(314, 31);
            editManagerCombobox.TabIndex = 16;
            // 
            // editDeadlinePicker
            // 
            editDeadlinePicker.Cursor = Cursors.Hand;
            editDeadlinePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editDeadlinePicker.Location = new Point(0, 256);
            editDeadlinePicker.Name = "editDeadlinePicker";
            editDeadlinePicker.Size = new Size(314, 30);
            editDeadlinePicker.TabIndex = 11;
            // 
            // editCreationDatePicker
            // 
            editCreationDatePicker.Cursor = Cursors.Hand;
            editCreationDatePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editCreationDatePicker.Location = new Point(0, 339);
            editCreationDatePicker.Name = "editCreationDatePicker";
            editCreationDatePicker.Size = new Size(314, 30);
            editCreationDatePicker.TabIndex = 15;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.FromArgb(52, 152, 62);
            editButton.Location = new Point(0, 402);
            editButton.Name = "editButton";
            editButton.Size = new Size(102, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(52, 152, 62);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(200, 27);
            label2.TabIndex = 0;
            label2.Text = "Редактировать заказ";
            // 
            // editStatusCombobox
            // 
            editStatusCombobox.Cursor = Cursors.Hand;
            editStatusCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editStatusCombobox.FormattingEnabled = true;
            editStatusCombobox.Location = new Point(0, 80);
            editStatusCombobox.Name = "editStatusCombobox";
            editStatusCombobox.Size = new Size(314, 31);
            editStatusCombobox.TabIndex = 12;
            // 
            // orderPanel
            // 
            orderPanel.Controls.Add(deleteButton);
            orderPanel.Controls.Add(managerNameLabel);
            orderPanel.Controls.Add(deadlineLabel);
            orderPanel.Controls.Add(clientNameLabel);
            orderPanel.Controls.Add(creationDateLabel);
            orderPanel.Controls.Add(amountLabel);
            orderPanel.Controls.Add(openEditButton);
            orderPanel.Controls.Add(productNameLabel);
            orderPanel.Location = new Point(319, 325);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(309, 312);
            orderPanel.TabIndex = 14;
            orderPanel.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.FromArgb(52, 152, 62);
            deleteButton.Location = new Point(175, 248);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(131, 35);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // managerNameLabel
            // 
            managerNameLabel.AutoSize = true;
            managerNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            managerNameLabel.Location = new Point(3, 203);
            managerNameLabel.Name = "managerNameLabel";
            managerNameLabel.Size = new Size(104, 26);
            managerNameLabel.TabIndex = 8;
            managerNameLabel.Text = "Менеджер";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deadlineLabel.Location = new Point(3, 163);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(157, 26);
            deadlineLabel.TabIndex = 7;
            deadlineLabel.Text = "Дата окончания";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientNameLabel.Location = new Point(3, 84);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(177, 26);
            clientNameLabel.TabIndex = 6;
            clientNameLabel.Text = "Название клиента";
            // 
            // creationDateLabel
            // 
            creationDateLabel.AutoSize = true;
            creationDateLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            creationDateLabel.Location = new Point(3, 122);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new Size(145, 26);
            creationDateLabel.TabIndex = 5;
            creationDateLabel.Text = "Дата создания";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(3, 44);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(119, 26);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Количество";
            // 
            // openEditButton
            // 
            openEditButton.AutoSize = true;
            openEditButton.Cursor = Cursors.Hand;
            openEditButton.FlatStyle = FlatStyle.Flat;
            openEditButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openEditButton.ForeColor = Color.FromArgb(52, 152, 62);
            openEditButton.Location = new Point(3, 248);
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
            productNameLabel.Size = new Size(98, 26);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Название";
            // 
            // addPanel
            // 
            addPanel.Controls.Add(label7);
            addPanel.Controls.Add(label6);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Controls.Add(addDeadlinePicker);
            addPanel.Controls.Add(addIdCombobox);
            addPanel.Controls.Add(addCreationDatePicker);
            addPanel.Controls.Add(addStatusCombobox);
            addPanel.Controls.Add(addManagerCombobox);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(38, 117);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(257, 521);
            addPanel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 396);
            label7.Name = "label7";
            label7.Size = new Size(157, 26);
            label7.TabIndex = 15;
            label7.Text = "Дата окончания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 310);
            label6.Name = "label6";
            label6.Size = new Size(145, 26);
            label6.TabIndex = 14;
            label6.Text = "Дата создания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 227);
            label5.Name = "label5";
            label5.Size = new Size(104, 26);
            label5.TabIndex = 13;
            label5.Text = "Менеджер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 137);
            label4.Name = "label4";
            label4.Size = new Size(71, 26);
            label4.TabIndex = 12;
            label4.Text = "Статус";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 51);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 11;
            label3.Text = "Заявка";
            // 
            // addDeadlinePicker
            // 
            addDeadlinePicker.Cursor = Cursors.Hand;
            addDeadlinePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addDeadlinePicker.Location = new Point(0, 425);
            addDeadlinePicker.Name = "addDeadlinePicker";
            addDeadlinePicker.Size = new Size(257, 30);
            addDeadlinePicker.TabIndex = 10;
            // 
            // addIdCombobox
            // 
            addIdCombobox.Cursor = Cursors.Hand;
            addIdCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addIdCombobox.FormattingEnabled = true;
            addIdCombobox.Location = new Point(0, 80);
            addIdCombobox.Name = "addIdCombobox";
            addIdCombobox.Size = new Size(257, 31);
            addIdCombobox.TabIndex = 9;
            // 
            // addCreationDatePicker
            // 
            addCreationDatePicker.CalendarFont = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCreationDatePicker.Cursor = Cursors.Hand;
            addCreationDatePicker.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addCreationDatePicker.Location = new Point(0, 339);
            addCreationDatePicker.Name = "addCreationDatePicker";
            addCreationDatePicker.Size = new Size(257, 30);
            addCreationDatePicker.TabIndex = 8;
            // 
            // addStatusCombobox
            // 
            addStatusCombobox.Cursor = Cursors.Hand;
            addStatusCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStatusCombobox.FormattingEnabled = true;
            addStatusCombobox.Location = new Point(0, 166);
            addStatusCombobox.Name = "addStatusCombobox";
            addStatusCombobox.Size = new Size(257, 31);
            addStatusCombobox.TabIndex = 6;
            // 
            // addManagerCombobox
            // 
            addManagerCombobox.Cursor = Cursors.Hand;
            addManagerCombobox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addManagerCombobox.FormattingEnabled = true;
            addManagerCombobox.Location = new Point(0, 256);
            addManagerCombobox.Name = "addManagerCombobox";
            addManagerCombobox.Size = new Size(257, 31);
            addManagerCombobox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.FromArgb(52, 152, 62);
            addButton.Location = new Point(3, 485);
            addButton.Name = "addButton";
            addButton.Size = new Size(104, 35);
            addButton.TabIndex = 4;
            addButton.Text = "Оформить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 152, 62);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(162, 27);
            label1.TabIndex = 0;
            label1.Text = "Оформить заказ";
            // 
            // ordersListView
            // 
            ordersListView.Cursor = Cursors.Hand;
            ordersListView.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ordersListView.Location = new Point(319, 117);
            ordersListView.Name = "ordersListView";
            ordersListView.Size = new Size(309, 187);
            ordersListView.TabIndex = 12;
            ordersListView.UseCompatibleStateImageBehavior = false;
            ordersListView.View = View.Tile;
            ordersListView.MouseClick += ordersListView_MouseClick;
            // 
            // clientsButton
            // 
            clientsButton.AutoSize = true;
            clientsButton.BackColor = Color.White;
            clientsButton.Cursor = Cursors.Hand;
            clientsButton.FlatStyle = FlatStyle.Flat;
            clientsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientsButton.ForeColor = Color.FromArgb(52, 152, 62);
            clientsButton.Location = new Point(38, 29);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(92, 35);
            clientsButton.TabIndex = 19;
            clientsButton.Text = "Клиенты";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.AutoSize = true;
            ordersButton.BackColor = Color.FromArgb(118, 227, 131);
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ordersButton.ForeColor = Color.White;
            ordersButton.Location = new Point(300, 29);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(76, 35);
            ordersButton.TabIndex = 18;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = false;
            // 
            // requestsButton
            // 
            requestsButton.AutoSize = true;
            requestsButton.Cursor = Cursors.Hand;
            requestsButton.FlatStyle = FlatStyle.Flat;
            requestsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsButton.ForeColor = Color.FromArgb(52, 152, 62);
            requestsButton.Location = new Point(220, 29);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(75, 35);
            requestsButton.TabIndex = 17;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = true;
            requestsButton.Click += requestsButton_Click;
            // 
            // productsButton
            // 
            productsButton.AutoSize = true;
            productsButton.BackColor = Color.White;
            productsButton.Cursor = Cursors.Hand;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsButton.ForeColor = Color.FromArgb(52, 152, 62);
            productsButton.Location = new Point(134, 29);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(80, 35);
            productsButton.TabIndex = 16;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.FromArgb(52, 152, 62);
            label12.Location = new Point(821, 33);
            label12.Name = "label12";
            label12.Size = new Size(88, 26);
            label12.TabIndex = 21;
            label12.Text = "Экопрод";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(914, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 786);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(clientsButton);
            Controls.Add(ordersButton);
            Controls.Add(requestsButton);
            Controls.Add(productsButton);
            Controls.Add(editPanel);
            Controls.Add(orderPanel);
            Controls.Add(addPanel);
            Controls.Add(ordersListView);
            Name = "OrdersView";
            Text = "Заказы";
            Load += OrdersView_Load;
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            orderPanel.ResumeLayout(false);
            orderPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button clientsButton;
        private Button ordersButton;
        private Button requestsButton;
        private Button productsButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button deleteButton;
        private Label label12;
        private PictureBox pictureBox1;
    }
}
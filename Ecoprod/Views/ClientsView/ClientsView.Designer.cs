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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsView));
            clientsListview = new ListView();
            addPanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            addButton = new Button();
            addEmailTextbox = new TextBox();
            addPhoneTextbox = new TextBox();
            addNameTextbox = new TextBox();
            label1 = new Label();
            clientPanel = new Panel();
            deleteButton = new Button();
            openEditButton = new Button();
            clientEmailLabel = new Label();
            clientPhoneLabel = new Label();
            clientNameLabel = new Label();
            editPanel = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            editButton = new Button();
            editEmailTextbox = new TextBox();
            editPhoneTextbox = new TextBox();
            editNameTextbox = new TextBox();
            label2 = new Label();
            productsButton = new Button();
            requestsButton = new Button();
            ordersButton = new Button();
            button1 = new Button();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            addPanel.SuspendLayout();
            clientPanel.SuspendLayout();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // clientsListview
            // 
            clientsListview.BorderStyle = BorderStyle.FixedSingle;
            clientsListview.Cursor = Cursors.Hand;
            clientsListview.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientsListview.ForeColor = Color.Black;
            clientsListview.Location = new Point(284, 121);
            clientsListview.Name = "clientsListview";
            clientsListview.Size = new Size(269, 311);
            clientsListview.TabIndex = 0;
            clientsListview.UseCompatibleStateImageBehavior = false;
            clientsListview.View = View.Tile;
            clientsListview.MouseClick += clientsListview_MouseClick;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(addEmailTextbox);
            addPanel.Controls.Add(addPhoneTextbox);
            addPanel.Controls.Add(addNameTextbox);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(31, 121);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(229, 316);
            addPanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 199);
            label5.Name = "label5";
            label5.Size = new Size(58, 26);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 116);
            label4.Name = "label4";
            label4.Size = new Size(94, 26);
            label4.TabIndex = 6;
            label4.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 5;
            label3.Text = "Название";
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.FromArgb(52, 152, 62);
            addButton.Location = new Point(0, 280);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addEmailTextbox
            // 
            addEmailTextbox.Cursor = Cursors.IBeam;
            addEmailTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addEmailTextbox.Location = new Point(0, 228);
            addEmailTextbox.Name = "addEmailTextbox";
            addEmailTextbox.PlaceholderText = "Email";
            addEmailTextbox.Size = new Size(229, 30);
            addEmailTextbox.TabIndex = 3;
            // 
            // addPhoneTextbox
            // 
            addPhoneTextbox.Cursor = Cursors.IBeam;
            addPhoneTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addPhoneTextbox.Location = new Point(0, 145);
            addPhoneTextbox.Name = "addPhoneTextbox";
            addPhoneTextbox.PlaceholderText = "Телефон";
            addPhoneTextbox.Size = new Size(229, 30);
            addPhoneTextbox.TabIndex = 2;
            // 
            // addNameTextbox
            // 
            addNameTextbox.Cursor = Cursors.IBeam;
            addNameTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNameTextbox.Location = new Point(0, 70);
            addNameTextbox.Name = "addNameTextbox";
            addNameTextbox.PlaceholderText = "Название";
            addNameTextbox.Size = new Size(229, 30);
            addNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 152, 62);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(182, 27);
            label1.TabIndex = 0;
            label1.Text = "Добавить клиента";
            // 
            // clientPanel
            // 
            clientPanel.Controls.Add(deleteButton);
            clientPanel.Controls.Add(openEditButton);
            clientPanel.Controls.Add(clientEmailLabel);
            clientPanel.Controls.Add(clientPhoneLabel);
            clientPanel.Controls.Add(clientNameLabel);
            clientPanel.Location = new Point(284, 454);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(269, 151);
            clientPanel.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.FromArgb(52, 152, 62);
            deleteButton.Location = new Point(166, 114);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 35);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // openEditButton
            // 
            openEditButton.AutoSize = true;
            openEditButton.Cursor = Cursors.Hand;
            openEditButton.FlatStyle = FlatStyle.Flat;
            openEditButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openEditButton.ForeColor = Color.FromArgb(52, 152, 62);
            openEditButton.Location = new Point(1, 114);
            openEditButton.Name = "openEditButton";
            openEditButton.Size = new Size(133, 35);
            openEditButton.TabIndex = 3;
            openEditButton.Text = "Редактировать";
            openEditButton.UseVisualStyleBackColor = true;
            openEditButton.Click += openEditButton_Click;
            // 
            // clientEmailLabel
            // 
            clientEmailLabel.AutoSize = true;
            clientEmailLabel.Font = new Font("Comic Sans MS", 14.25F);
            clientEmailLabel.Location = new Point(3, 74);
            clientEmailLabel.Name = "clientEmailLabel";
            clientEmailLabel.Size = new Size(148, 26);
            clientEmailLabel.TabIndex = 2;
            clientEmailLabel.Text = "Почта клиента";
            // 
            // clientPhoneLabel
            // 
            clientPhoneLabel.AutoSize = true;
            clientPhoneLabel.Font = new Font("Comic Sans MS", 14.25F);
            clientPhoneLabel.Location = new Point(3, 37);
            clientPhoneLabel.Name = "clientPhoneLabel";
            clientPhoneLabel.Size = new Size(173, 26);
            clientPhoneLabel.TabIndex = 1;
            clientPhoneLabel.Text = "Телефон клиента";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientNameLabel.ForeColor = Color.FromArgb(52, 152, 62);
            clientNameLabel.Location = new Point(3, 0);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(177, 26);
            clientNameLabel.TabIndex = 0;
            clientNameLabel.Text = "Название клиента";
            // 
            // editPanel
            // 
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(label7);
            editPanel.Controls.Add(label6);
            editPanel.Controls.Add(editButton);
            editPanel.Controls.Add(editEmailTextbox);
            editPanel.Controls.Add(editPhoneTextbox);
            editPanel.Controls.Add(editNameTextbox);
            editPanel.Controls.Add(label2);
            editPanel.Location = new Point(582, 121);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(319, 342);
            editPanel.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 212);
            label8.Name = "label8";
            label8.Size = new Size(58, 26);
            label8.TabIndex = 8;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 122);
            label7.Name = "label7";
            label7.Size = new Size(94, 26);
            label7.TabIndex = 7;
            label7.Text = "Телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 44);
            label6.Name = "label6";
            label6.Size = new Size(98, 26);
            label6.TabIndex = 6;
            label6.Text = "Название";
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.FromArgb(52, 152, 62);
            editButton.Location = new Point(0, 302);
            editButton.Name = "editButton";
            editButton.Size = new Size(131, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editEmailTextbox
            // 
            editEmailTextbox.Cursor = Cursors.IBeam;
            editEmailTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editEmailTextbox.Location = new Point(0, 241);
            editEmailTextbox.Name = "editEmailTextbox";
            editEmailTextbox.PlaceholderText = "Email";
            editEmailTextbox.Size = new Size(319, 30);
            editEmailTextbox.TabIndex = 3;
            // 
            // editPhoneTextbox
            // 
            editPhoneTextbox.Cursor = Cursors.IBeam;
            editPhoneTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editPhoneTextbox.Location = new Point(0, 151);
            editPhoneTextbox.Name = "editPhoneTextbox";
            editPhoneTextbox.PlaceholderText = "Телефон";
            editPhoneTextbox.Size = new Size(319, 30);
            editPhoneTextbox.TabIndex = 2;
            // 
            // editNameTextbox
            // 
            editNameTextbox.Cursor = Cursors.IBeam;
            editNameTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editNameTextbox.Location = new Point(0, 73);
            editNameTextbox.Name = "editNameTextbox";
            editNameTextbox.PlaceholderText = "Название";
            editNameTextbox.Size = new Size(319, 30);
            editNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(52, 152, 62);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(228, 27);
            label2.TabIndex = 0;
            label2.Text = "Редактировать клиента";
            // 
            // productsButton
            // 
            productsButton.AutoSize = true;
            productsButton.Cursor = Cursors.Hand;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsButton.ForeColor = Color.FromArgb(52, 152, 62);
            productsButton.Location = new Point(127, 25);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(80, 35);
            productsButton.TabIndex = 4;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.AutoSize = true;
            requestsButton.Cursor = Cursors.Hand;
            requestsButton.FlatStyle = FlatStyle.Flat;
            requestsButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsButton.ForeColor = Color.FromArgb(52, 152, 62);
            requestsButton.Location = new Point(213, 25);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(75, 35);
            requestsButton.TabIndex = 5;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = true;
            requestsButton.Click += requestsButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.AutoSize = true;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ordersButton.ForeColor = Color.FromArgb(52, 152, 62);
            ordersButton.Location = new Point(293, 25);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(76, 35);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(118, 227, 131);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 25);
            button1.Name = "button1";
            button1.Size = new Size(92, 35);
            button1.TabIndex = 7;
            button1.Text = "Клиенты";
            button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.FromArgb(52, 152, 62);
            label11.Location = new Point(755, 29);
            label11.Name = "label11";
            label11.Size = new Size(88, 26);
            label11.TabIndex = 19;
            label11.Text = "Экопрод";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(848, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // ClientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(972, 805);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(ordersButton);
            Controls.Add(requestsButton);
            Controls.Add(productsButton);
            Controls.Add(editPanel);
            Controls.Add(clientPanel);
            Controls.Add(addPanel);
            Controls.Add(clientsListview);
            Name = "ClientsView";
            Text = "Клиенты";
            Load += ClientsView_Load;
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            clientPanel.ResumeLayout(false);
            clientPanel.PerformLayout();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button deleteButton;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
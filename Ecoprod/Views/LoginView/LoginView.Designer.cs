namespace Ecoprod.Views.LoginView
{
    partial class LoginView
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
            label1 = new Label();
            loginTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(173, 75);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Войти";
            // 
            // loginTextbox
            // 
            loginTextbox.Cursor = Cursors.IBeam;
            loginTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTextbox.Location = new Point(173, 127);
            loginTextbox.Name = "loginTextbox";
            loginTextbox.Size = new Size(139, 30);
            loginTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(97, 127);
            label2.Name = "label2";
            label2.Size = new Size(69, 26);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(85, 185);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Cursor = Cursors.IBeam;
            passwordTextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextbox.Location = new Point(173, 184);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(139, 30);
            passwordTextbox.TabIndex = 3;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.AutoSize = true;
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.FromArgb(52, 152, 62);
            loginButton.Location = new Point(173, 239);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(80, 38);
            loginButton.TabIndex = 5;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 385);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(passwordTextbox);
            Controls.Add(label2);
            Controls.Add(loginTextbox);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginTextbox;
        private Label label2;
        private Label label3;
        private TextBox passwordTextbox;
        private Button loginButton;
    }
}
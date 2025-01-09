namespace Restuaracja
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameLabel = new Label();
            loginInput = new TextBox();
            label2 = new Label();
            passInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label1.Location = new Point(171, 11);
            label1.Name = "label1";
            label1.Size = new Size(415, 34);
            label1.TabIndex = 0;
            label1.Text = "Logowanie do systemu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            nameLabel.Location = new Point(240, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(98, 26);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Login:";
            // 
            // loginInput
            // 
            loginInput.Font = new Font("Segoe UI", 12F);
            loginInput.Location = new Point(240, 118);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(290, 29);
            loginInput.TabIndex = 30;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label2.Location = new Point(240, 188);
            label2.Name = "label2";
            label2.Size = new Size(136, 26);
            label2.TabIndex = 31;
            label2.Text = "Hasło:";
            label2.Click += label2_Click;
            // 
            // passInput
            // 
            passInput.Font = new Font("Segoe UI", 12F);
            passInput.Location = new Point(240, 219);
            passInput.Name = "passInput";
            passInput.PasswordChar = '*';
            passInput.Size = new Size(290, 29);
            passInput.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(240, 263);
            button1.Name = "button1";
            button1.Size = new Size(290, 75);
            button1.TabIndex = 33;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 8, 29);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(225, 187, 130);
            button2.Location = new Point(430, 355);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 33);
            button2.TabIndex = 34;
            button2.Text = "Rejstracja";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(882, 536);
            button3.Name = "button3";
            button3.Size = new Size(19, 29);
            button3.TabIndex = 35;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(passInput);
            Controls.Add(nameLabel);
            Controls.Add(loginInput);
            Controls.Add(label1);
            Name = "LoginView";
            Size = new Size(800, 450);
            Load += LoginView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLabel;
        private TextBox loginInput;
        private Label label2;
        private TextBox passInput;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

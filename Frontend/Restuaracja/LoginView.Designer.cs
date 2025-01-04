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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(240, 13);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 0;
            label1.Text = "Logowanie do systemu";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 15F);
            nameLabel.Location = new Point(240, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 28);
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
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(240, 188);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 31;
            label2.Text = "Hasło:";
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
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(240, 307);
            button1.Name = "button1";
            button1.Size = new Size(290, 75);
            button1.TabIndex = 33;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}

namespace Restuaracja.Orders
{
    partial class ChangeOrderStatus
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(184, 136);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 0;
            button1.Text = "Zmień Status Zamówienia";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Confirmed", "Shipped", "Delivered", "Cancelled" });
            comboBox1.Location = new Point(163, 88);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ChangeOrderStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(522, 227);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangeOrderStatus";
            Text = "ChangeOrderStatus";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
    }
}
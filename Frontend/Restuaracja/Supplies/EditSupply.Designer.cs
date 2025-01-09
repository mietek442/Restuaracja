namespace Restuaracja.Supplies
{
    partial class EditSupply
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
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(170, 105);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(151, 25);
            numericUpDown1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 26;
            label2.Text = "Jednostka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 105);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 25);
            textBox1.TabIndex = 27;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(13, 81);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(47, 20);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Nazwa";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(13, 105);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 25);
            nameTextBox.TabIndex = 24;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(170, 81);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(39, 20);
            priceLabel.TabIndex = 25;
            priceLabel.Text = "Ilość";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(309, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(513, 84);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 69);
            button1.TabIndex = 30;
            button1.Text = "Zatwierdz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditSupply
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(618, 167);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditSupply";
            Load += EditSupply_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label2;
        private TextBox textBox1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label priceLabel;
        private Label label1;
        private Button button1;
    }
}

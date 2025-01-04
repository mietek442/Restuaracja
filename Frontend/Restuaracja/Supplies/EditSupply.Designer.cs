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
            numericUpDown1.Location = new Point(149, 79);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(132, 23);
            numericUpDown1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 26;
            label2.Text = "Jednostka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 27;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(11, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Nazwa";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(11, 79);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(132, 23);
            nameTextBox.TabIndex = 24;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(149, 61);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(31, 15);
            priceLabel.TabIndex = 25;
            priceLabel.Text = "Ilość";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(449, 63);
            button1.Name = "button1";
            button1.Size = new Size(80, 52);
            button1.TabIndex = 30;
            button1.Text = "Zatwierdz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditSupply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 125);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
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

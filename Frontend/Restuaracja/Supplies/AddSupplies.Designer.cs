namespace Restuaracja.Supplies
{
    partial class AddSupplies
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
            nameTextBox = new TextBox();
            priceLabel = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(299, 10);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 3;
            label1.Text = "Dodaj Produkt";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(299, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Nazwa";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(299, 106);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 17;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(299, 152);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(31, 15);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Ilość";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 208);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 20;
            label2.Text = "Jednostka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(299, 170);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(299, 290);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 23;
            button1.Text = "Gotowe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 370);
            button2.Name = "button2";
            button2.Size = new Size(108, 77);
            button2.TabIndex = 24;
            button2.Text = "Powrót";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddSupplies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(label1);
            Name = "AddSupplies";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label priceLabel;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
    }
}

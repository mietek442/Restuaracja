namespace Restuaracja.Orders
{
    partial class DishOrderComp
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
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = false;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox1.ForeColor = SystemColors.Desktop;
            checkBox1.Location = new Point(13, 63);
            checkBox1.Name = "checkBox1";
            
            checkBox1.Size = new Size(150, 50);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Dodaj Produkt";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.FlatAppearance.BorderSize = 1;
            checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 250);
            checkBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0);
            checkBox1.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(200, 200, 200);

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(35, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(322, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(35, 116);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(411, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 116);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DishOrderComp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Name = "DishOrderComp";
            Size = new Size(620, 150);
            Load += DishOrderComp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}

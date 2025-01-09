namespace Restuaracja.Components
{
    partial class DishComp
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label1.Location = new Point(11, 23);
            label1.MinimumSize = new Size(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(217, 217, 217);
            label3.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label3.Location = new Point(98, 14);
            label3.MinimumSize = new Size(86, 122);
            label3.Name = "label3";
            label3.Size = new Size(86, 122);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(326, 15);
            button1.Name = "button1";
            button1.Size = new Size(91, 52);
            button1.TabIndex = 3;
            button1.Text = "Edytuj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(208, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 122);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(326, 73);
            button2.Name = "button2";
            button2.Size = new Size(91, 52);
            button2.TabIndex = 5;
            button2.Text = "Usuń";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DishComp
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            Name = "DishComp";
            Size = new Size(417, 153);
            Load += DishComp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
    }
}

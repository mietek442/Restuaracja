namespace Restuaracja.Menu
{
    partial class EditDishView
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox5 = new TextBox();
            uploadButton = new Button();
            pictureBox = new PictureBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox6 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            label1.Location = new Point(193, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Nazwa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 22);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 97);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 58);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label3.Location = new Point(10, 101);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 3;
            label3.Text = "Krótki opis:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 161);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 110);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label4.Location = new Point(10, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 5;
            label4.Text = "Długi opis:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 22);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label5.Location = new Point(10, 281);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 7;
            label5.Text = "Kuchnia:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            checkBox1.Location = new Point(81, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 20);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Czy jest dostępne";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label6.Location = new Point(10, 336);
            label6.Name = "label6";
            label6.Size = new Size(38, 16);
            label6.TabIndex = 12;
            label6.Text = "Cena:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 333);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 22);
            textBox5.TabIndex = 13;
            // 
            // uploadButton
            // 
            uploadButton.BackColor = Color.FromArgb(2, 8, 29);
            uploadButton.FlatStyle = FlatStyle.Flat;
            uploadButton.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            uploadButton.ForeColor = Color.FromArgb(225, 187, 130);
            uploadButton.Location = new Point(290, 62);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(90, 55);
            uploadButton.TabIndex = 16;
            uploadButton.Text = "Dodaj nowe zdjęcie";
            uploadButton.UseVisualStyleBackColor = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(246, 121);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(171, 160);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 17;
            pictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(285, 331);
            button1.Name = "button1";
            button1.Size = new Size(94, 80);
            button1.TabIndex = 18;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(81, 364);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(137, 22);
            textBox6.TabIndex = 20;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label7.Location = new Point(10, 367);
            label7.Name = "label7";
            label7.Size = new Size(65, 16);
            label7.TabIndex = 19;
            label7.Text = "Rabat w %:";
            // 
            // EditDishView
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(464, 442);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox);
            Controls.Add(uploadButton);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            Name = "EditDishView";
            Load += EditDishView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox textBox5;
        private Button uploadButton;
        private PictureBox pictureBox;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox6;
        private Label label7;
    }
}

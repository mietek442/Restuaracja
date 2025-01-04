namespace Restuaracja.User
{
    partial class UserControl2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            splitter1 = new Splitter();
            button2 = new Button();
            splitter2 = new Splitter();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(splitter1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(splitter2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(265, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 285);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 5;
            label1.Text = "Rejestracja";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 57);
            textBox1.Margin = new Padding(3, 20, 3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 120);
            textBox2.Margin = new Padding(3, 20, 3, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(3, 166);
            button1.Name = "button1";
            button1.Size = new Size(268, 70);
            button1.TabIndex = 0;
            button1.Text = "Zarejestruj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 242);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 0);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(3, 248);
            button2.Name = "button2";
            button2.Size = new Size(104, 30);
            button2.TabIndex = 6;
            button2.Text = "Logowanie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(277, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 0);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(3, 375);
            button3.Name = "button3";
            button3.Size = new Size(128, 72);
            button3.TabIndex = 2;
            button3.Text = "Powrót";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Name = "UserControl2";
            Size = new Size(800, 450);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Splitter splitter1;
        private Splitter splitter2;
        private Button button3;
    }
}

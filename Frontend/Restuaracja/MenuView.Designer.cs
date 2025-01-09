namespace Restuaracja
{
    partial class MenuView
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 375);
            button1.Name = "button1";
            button1.Size = new Size(128, 72);
            button1.TabIndex = 0;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(276, 3);
            button2.Name = "button2";
            button2.Size = new Size(253, 59);
            button2.TabIndex = 1;
            button2.Text = "Dodaj Danie";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(142, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(538, 342);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuView";
            Size = new Size(800, 450);
            Load += MenuView_Load;
            ResumeLayout(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            this.Controls.Add(menu);
        }

        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

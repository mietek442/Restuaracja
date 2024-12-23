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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 375);
            button1.Name = "button1";
            button1.Size = new Size(128, 72);
            button1.TabIndex = 0;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 41);
            button2.Name = "button2";
            button2.Size = new Size(121, 47);
            button2.TabIndex = 1;
            button2.Text = "Dodaj Danie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuView";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            this.Controls.Add(menu);
        }

        private Button button2;
    }
}

namespace Restuaracja
{
    partial class OrdersView
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Sprawdz = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(3, 375);
            button1.Name = "button1";
            button1.Size = new Size(128, 72);
            button1.TabIndex = 3;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(299, 11);
            label1.Name = "label1";
            label1.Size = new Size(300, 50);
            label1.TabIndex = 2;
            label1.Text = "Złóż Zamówienia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 8, 29);
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(225, 187, 130);
            button2.Location = new Point(654, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 37);
            button2.TabIndex = 4;
            button2.Text = "Lista Zamówień";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(84, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(623, 395);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Sprawdz
            // 
            Sprawdz.Location = new Point(713, 231);
            Sprawdz.Name = "Sprawdz";
            Sprawdz.Size = new Size(75, 23);
            Sprawdz.TabIndex = 6;
            Sprawdz.Text = "Zamow";
            Sprawdz.UseVisualStyleBackColor = true;
            Sprawdz.Click += Sprawdz_Click;
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(Sprawdz);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "OrdersView";
            Size = new Size(800, 450);
            Load += OrdersView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Sprawdz;
    }
}

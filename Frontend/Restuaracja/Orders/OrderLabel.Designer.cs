namespace Restuaracja.Orders
{
    partial class OrderLabel
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
            panel1 = new Panel();
            button2 = new Button();
            OrderPrice = new Label();
            button1 = new Button();
            labelCreatedAt = new Label();
            labelStatus = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(OrderPrice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelCreatedAt);
            panel1.Controls.Add(labelStatus);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 70);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 8, 29);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(225, 187, 130);
            button2.Location = new Point(105, 44);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 4;
            button2.Text = "Zmień Status";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // OrderPrice
            // 
            OrderPrice.AutoSize = true;
            OrderPrice.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            OrderPrice.Location = new Point(286, 3);
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Size = new Size(66, 16);
            OrderPrice.TabIndex = 4;
            OrderPrice.Text = "OrderPrice:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(298, 44);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 3;
            button1.Text = "Rozwiń Dane Produktów";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelCreatedAt
            // 
            labelCreatedAt.AutoSize = true;
            labelCreatedAt.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            labelCreatedAt.Location = new Point(3, 30);
            labelCreatedAt.Name = "labelCreatedAt";
            labelCreatedAt.Size = new Size(87, 16);
            labelCreatedAt.TabIndex = 0;
            labelCreatedAt.Text = "Id Zamówienia:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            labelStatus.Location = new Point(3, 53);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 16);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(16, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(437, 15);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // OrderLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "OrderLabel";
            Size = new Size(479, 97);
            Load += OrderLabel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
        private Button button1;
        private Label OrderPrice;
        private Label labelCreatedAt;
        private FlowLayoutPanel flowLayoutPanel1;

        

        private void AdjustLayout()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                Size = new Size(419, 412);
                flowLayoutPanel1.Height = 0;
            }
            else
            {
                Size = new Size(419, Math.Min(900, flowLayoutPanel1.PreferredSize.Height + 100));
                flowLayoutPanel1.Height = Math.Min(900, flowLayoutPanel1.PreferredSize.Height);
            }
        }

        private Button button2;
    }
}

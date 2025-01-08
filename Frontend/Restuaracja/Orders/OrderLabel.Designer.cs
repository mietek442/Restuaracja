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
            OrderPrice = new Label();
            button1 = new Button();
            labelCreatedAt = new Label();
            labelStatus = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
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
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 93);
            panel1.TabIndex = 0;
            // 
            // OrderPrice
            // 
            OrderPrice.AutoSize = true;
            OrderPrice.Location = new Point(327, 4);
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Size = new Size(82, 20);
            OrderPrice.TabIndex = 4;
            OrderPrice.Text = "OrderPrice:";
            // 
            // button1
            // 
            button1.Location = new Point(340, 58);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 31);
            button1.TabIndex = 3;
            button1.Text = "Rozwiń Dane Produktów";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // labelCreatedAt
            // 
            labelCreatedAt.AutoSize = true;
            labelCreatedAt.Location = new Point(3, 40);
            labelCreatedAt.Name = "labelCreatedAt";
            labelCreatedAt.Size = new Size(111, 20);
            labelCreatedAt.TabIndex = 0;
            labelCreatedAt.Text = "Id Zamówienia:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(3, 71);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(56, 20);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(18, 105);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(499, 20);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(183, 61);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 5;
            button2.Text = "Zmień Status";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderLabel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderLabel";
            Size = new Size(547, 129);
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

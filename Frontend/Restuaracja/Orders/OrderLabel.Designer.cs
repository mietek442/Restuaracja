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
            labelUpdatedAt = new Label();
            labelStatus = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(OrderPrice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelCreatedAt);
            panel1.Controls.Add(labelUpdatedAt);
            panel1.Controls.Add(labelStatus);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 70);
            panel1.TabIndex = 0;
            // 
            // OrderPrice
            // 
            OrderPrice.AutoSize = true;
            OrderPrice.Location = new Point(286, 3);
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Size = new Size(66, 15);
            OrderPrice.TabIndex = 4;
            OrderPrice.Text = "OrderPrice:";
            // 
            // button1
            // 
            button1.Location = new Point(245, 44);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 3;
            button1.Text = "Rozwiń Dane Produktów";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // labelCreatedAt
            // 
            labelCreatedAt.AutoSize = true;
            labelCreatedAt.Location = new Point(3, 3);
            labelCreatedAt.Name = "labelCreatedAt";
            labelCreatedAt.Size = new Size(88, 15);
            labelCreatedAt.TabIndex = 0;
            labelCreatedAt.Text = "Id Zamówienia:";
            // 
            // labelUpdatedAt
            // 
            labelUpdatedAt.AutoSize = true;
            labelUpdatedAt.Location = new Point(3, 28);
            labelUpdatedAt.Name = "labelUpdatedAt";
            labelUpdatedAt.Size = new Size(106, 15);
            labelUpdatedAt.TabIndex = 1;
            labelUpdatedAt.Text = "Id Zamawiajacego:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(3, 53);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(45, 15);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(6, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(409, 305);
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
            Size = new Size(419, 460);
            Load += OrderLabel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
        private Button button1;
        private Label OrderPrice;
        private Label labelCreatedAt;
        private Label labelUpdatedAt;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

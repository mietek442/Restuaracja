namespace Restuaracja.Orders
{
    partial class OrderItemView
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
            panel1 = new Panel();
            labelDishId = new Label();
            labelQuantity = new Label();
            labelTotalPrice = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelDishId);
            panel1.Controls.Add(labelQuantity);
            panel1.Controls.Add(labelTotalPrice);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 74);
            panel1.TabIndex = 0;
            // 
            // labelDishId
            // 
            labelDishId.Location = new Point(3, 10);
            labelDishId.Name = "labelDishId";
            labelDishId.Size = new Size(68, 15);
            labelDishId.TabIndex = 0;
            labelDishId.Text = "Dish Name:";
            // 
            // labelQuantity
            // 
            labelQuantity.Location = new Point(3, 30);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(56, 15);
            labelQuantity.TabIndex = 1;
            labelQuantity.Text = "Quantity:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.Location = new Point(3, 50);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(64, 15);
            labelTotalPrice.TabIndex = 2;
            labelTotalPrice.Text = "Total Price:";
            // 
            // OrderItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderItemView";
            Size = new Size(251, 95);
            Load += OrderItemView_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDishId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}

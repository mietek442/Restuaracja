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
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 99);
            panel1.TabIndex = 0;
            // 
            // labelDishId
            // 
            labelDishId.Location = new Point(3, 13);
            labelDishId.Name = "labelDishId";
            labelDishId.Size = new Size(271, 27);
            labelDishId.TabIndex = 0;
            labelDishId.Text = "Dish name ";
            // 
            // labelQuantity
            // 
            labelQuantity.Location = new Point(3, 40);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(64, 20);
            labelQuantity.TabIndex = 1;
            labelQuantity.Text = "Quantity:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.Location = new Point(3, 67);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(274, 32);
            labelTotalPrice.TabIndex = 2;
            labelTotalPrice.Text = "Total Price:";
            // 
            // OrderItemView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderItemView";
            Size = new Size(287, 127);
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

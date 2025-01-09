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
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 74);
            panel1.TabIndex = 0;
            // 
            // labelDishId
            // 
            labelDishId.Location = new Point(4, 10);
            labelDishId.Margin = new Padding(4, 0, 4, 0);
            labelDishId.Name = "labelDishId";
            labelDishId.Size = new Size(237, 20);
            labelDishId.TabIndex = 0;
            labelDishId.Text = "Dish name ";
            // 
            // labelQuantity
            // 
            labelQuantity.Location = new Point(4, 30);
            labelQuantity.Margin = new Padding(4, 0, 4, 0);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(233, 15);
            labelQuantity.TabIndex = 1;
            labelQuantity.Text = "Quantity:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.Location = new Point(4, 50);
            labelTotalPrice.Margin = new Padding(4, 0, 4, 0);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(240, 24);
            labelTotalPrice.TabIndex = 2;
            labelTotalPrice.Text = "Total Price:";
            // 
            // OrderItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
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

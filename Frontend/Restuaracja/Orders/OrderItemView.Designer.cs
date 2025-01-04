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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelDishId);
            panel1.Controls.Add(labelQuantity);
            panel1.Controls.Add(labelTotalPrice);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 74);
            panel1.TabIndex = 0;
            // 
            // labelDishId
            // 
            labelDishId.AutoSize = true;
            labelDishId.Location = new Point(3, 10);
            labelDishId.Name = "labelDishId";
            labelDishId.Size = new Size(68, 15);
            labelDishId.TabIndex = 0;
            labelDishId.Text = "Dish Name:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(3, 30);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(56, 15);
            labelQuantity.TabIndex = 1;
            labelQuantity.Text = "Quantity:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(3, 50);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(64, 15);
            labelTotalPrice.TabIndex = 2;
            labelTotalPrice.Text = "Total Price:";
            // 
            // button1
            // 
            button1.Location = new Point(321, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Details";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrderItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderItemView";
            Size = new Size(405, 80);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Load += OrderItemView_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDishId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button button1;
    }
}

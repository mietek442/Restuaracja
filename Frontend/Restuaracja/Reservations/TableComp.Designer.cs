namespace Restuaracja.Reservations
{
    partial class TableComp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            status = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 29);
            label1.TabIndex = 3;
            label1.Text = "Stolik nr.:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(199, 29);
            label2.TabIndex = 4;
            label2.Text = "Liczba miejsc:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            label3.Location = new Point(258, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 29);
            label3.TabIndex = 5;
            label3.Text = "Desc";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(330, 38);
            button5.Name = "button5";
            button5.Size = new Size(123, 28);
            button5.TabIndex = 6;
            button5.Text = "Pokaż rezerwacje";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // status
            // 
            status.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            status.Location = new Point(235, 33);
            status.Name = "status";
            status.Size = new Size(89, 29);
            status.TabIndex = 7;
            status.Text = "Desc";
            status.TextAlign = ContentAlignment.MiddleCenter;
            status.Click += label4_Click;
            // 
            // TableComp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(status);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TableComp";
            Size = new Size(456, 69);
            Load += TableComp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
        private Label status;
    }
}

namespace Restuaracja.Reservations
{
    partial class ReservationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(624, 246);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(221, -2);
            label3.Name = "label3";
            label3.Size = new Size(197, 29);
            label3.TabIndex = 6;
            label3.Text = "Desc";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(212, 282);
            button5.Name = "button5";
            button5.Size = new Size(216, 34);
            button5.TabIndex = 8;
            button5.Text = "Dodaj Rezerwację";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(648, 314);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Name = "ReservationForm";
            Text = "ReservationForm";
            Load += ReservationForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Button button5;
    }
}
namespace Restuaracja.Reservations
{
    partial class ReservationComp
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
            client = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // client
            // 
            client.Font = new Font("Arial Narrow", 13.25F, FontStyle.Bold);
            client.Location = new Point(3, 0);
            client.Name = "client";
            client.Size = new Size(664, 45);
            client.TabIndex = 6;
            client.Text = "Desc";
            client.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(183, 37);
            button5.Name = "button5";
            button5.Size = new Size(247, 45);
            button5.TabIndex = 7;
            button5.Text = "Anuluj Rezerwację";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ReservationComp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(client);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationComp";
            Size = new Size(667, 99);
            Load += ReservationComp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label client;
        private Button button5;
    }
}

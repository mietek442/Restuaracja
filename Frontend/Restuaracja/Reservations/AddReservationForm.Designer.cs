namespace Restuaracja.Reservations
{
    partial class AddReservationForm
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
            button1 = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            shortDescLabel = new Label();
            fullDescLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 8, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(225, 187, 130);
            button1.Location = new Point(348, 89);
            button1.Name = "button1";
            button1.Size = new Size(104, 45);
            button1.TabIndex = 12;
            button1.Text = "Gotowe";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            nameLabel.Location = new Point(23, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 16);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Imię klienta";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            nameTextBox.Location = new Point(127, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 22);
            nameTextBox.TabIndex = 14;
            // 
            // shortDescLabel
            // 
            shortDescLabel.AutoSize = true;
            shortDescLabel.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            shortDescLabel.Location = new Point(23, 104);
            shortDescLabel.Name = "shortDescLabel";
            shortDescLabel.Size = new Size(96, 16);
            shortDescLabel.TabIndex = 15;
            shortDescLabel.Text = "Data rozpoczęcia";
            // 
            // fullDescLabel
            // 
            fullDescLabel.AutoSize = true;
            fullDescLabel.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            fullDescLabel.Location = new Point(23, 144);
            fullDescLabel.Name = "fullDescLabel";
            fullDescLabel.Size = new Size(98, 16);
            fullDescLabel.TabIndex = 17;
            fullDescLabel.Text = "Data zakończenia";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(127, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial Narrow", 9.25F, FontStyle.Bold);
            dateTimePicker2.Location = new Point(127, 138);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 22);
            dateTimePicker2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            label1.Location = new Point(198, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(464, 178);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(shortDescLabel);
            Controls.Add(fullDescLabel);
            Name = "AddReservationForm";
            Text = "AddReservationForm";
            Load += AddReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label shortDescLabel;
        private Label fullDescLabel;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
    }
}
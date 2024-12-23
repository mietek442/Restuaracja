namespace Restuaracja
{
    partial class MenuView
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Label label1;
        private Button uploadButton; // Przycisk do uploadowania zdjęcia
        private PictureBox pictureBox; // Obrazek do wyświetlania zdjęcia
        private OpenFileDialog openFileDialog; // Okno do wyboru pliku

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            uploadButton = new Button();
            pictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();

            // 
            // button1 (Powrót)
            // 
            button1.Location = new Point(3, 375);
            button1.Name = "button1";
            button1.Size = new Size(128, 72);
            button1.TabIndex = 3;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // 
            // label1 (Menu restauracji)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 2;
            label1.Text = "Menu restauracji";

            // 
            // uploadButton (Przycisk do uploadowania zdjęcia)
            // 
            uploadButton.Location = new Point(500, 375);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(128, 72);
            uploadButton.TabIndex = 4;
            uploadButton.Text = "Upload zdjęcie";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;

            // 
            // pictureBox (Obrazek do wyświetlania zdjęcia)
            // 
            pictureBox.Location = new Point(300, 100);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 200);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;

            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";

            // 
            // MenuView (Główna kontrolka)
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uploadButton);
            Controls.Add(pictureBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuView";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath); // Wyświetlenie zdjęcia w PictureBoxie

                // Wysyłanie zdjęcia na backend
                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    var fileContent = new ByteArrayContent(await System.IO.File.ReadAllBytesAsync(filePath));
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                    formData.Add(fileContent, "file", System.IO.Path.GetFileName(filePath));

                    // Zmienna URL powinna zawierać endpoint backendu do uploadu zdjęcia
                    var response = await client.PostAsync("https://localhost:5001/api/files/pictures", formData);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Zdjęcie zostało pomyślnie przesłane.");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas wysyłania zdjęcia.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logika obsługi przycisku powrotu
        }
    }
}

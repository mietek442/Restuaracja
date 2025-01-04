using System;
using System.Drawing;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace Restuaracja.Menu
{
    public partial class AddDish : UserControl
    {


        public AddDish()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            MainMenu menu = new MainMenu();
            Controls.Add(menu);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath);
                using (var originalImage = Image.FromFile(filePath))
                using (var memoryStream = new System.IO.MemoryStream())
                {

                    originalImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageBytes = memoryStream.ToArray();

                    using (var client = new System.Net.Http.HttpClient())
                    using (var formData = new System.Net.Http.MultipartFormDataContent())
                    {
                        var fileContent = new System.Net.Http.ByteArrayContent(imageBytes);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");


                        formData.Add(fileContent, "request", "image.jpg");

                        var response = client.PostAsync("https://localhost:5001/api/files/pictures", formData).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            uploadedImageId = response.Content.ReadAsStringAsync().Result.Trim('"'); // Usuń cudzysłowy
                            MessageBox.Show("Zdjęcie zostało pomyślnie przesłane.");
                            Console.WriteLine(uploadedImageId);
                        }
                        else
                        {
                            var errorMessage = response.Content.ReadAsStringAsync().Result;
                            uploadedImageId = null;
                            MessageBox.Show($"Wystąpił błąd podczas wysyłania zdjęcia: {errorMessage}");
                        }
                    }
                }
            }
        }
        private async void buttonSendData_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(uploadedImageId))
            {

                var data = new
                {
                    name = nameTextBox.Text,
                    shortDescription = shortDescTextBox.Text,
                    fullDescription = fullDescTextBox.Text,
                    isAvailable = isAvailableCheckBox.Checked,
                    price = decimal.Parse(priceTextBox.Text),
                    discountPrice = decimal.Parse(discountPriceTextBox.Text)/100,
                    cuisine = cuisineTextBox.Text,
                    imageId = uploadedImageId
                };

                var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                using (var client = new System.Net.Http.HttpClient())
                {
                    var response = await client.PostAsync("https://localhost:5001/api/dishes", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Danie  Zostało dodane Prawidłowo.");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
                // MessageBox.Show($"Data to send:\n{jsonData}");


            }
            else
            {
                MessageBox.Show("Nie przesłano jeszcze obrazu.");
            }

        }
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            uploadButton = new Button();
            pictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            shortDescLabel = new Label();
            shortDescTextBox = new TextBox();
            fullDescLabel = new Label();
            fullDescTextBox = new TextBox();
            isAvailableLabel = new Label();
            isAvailableCheckBox = new CheckBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            discountPriceLabel = new Label();
            discountPriceTextBox = new TextBox();
            cuisineLabel = new Label();
            cuisineTextBox = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 389);
            button1.Name = "button1";
            button1.Size = new Size(104, 45);
            button1.TabIndex = 0;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 2;
            label1.Text = "Dodaj Danie";
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(34, 114);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(105, 36);
            uploadButton.TabIndex = 4;
            uploadButton.Text = "Dodaj Zdjecie";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(150, 114);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(34, 280);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Nazwa";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(138, 272);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 7;
            // 
            // shortDescLabel
            // 
            shortDescLabel.AutoSize = true;
            shortDescLabel.Location = new Point(34, 320);
            shortDescLabel.Name = "shortDescLabel";
            shortDescLabel.Size = new Size(82, 15);
            shortDescLabel.TabIndex = 8;
            shortDescLabel.Text = "Opis skrócony";
            // 
            // shortDescTextBox
            // 
            shortDescTextBox.Location = new Point(138, 312);
            shortDescTextBox.Name = "shortDescTextBox";
            shortDescTextBox.Size = new Size(200, 23);
            shortDescTextBox.TabIndex = 9;
            // 
            // fullDescLabel
            // 
            fullDescLabel.AutoSize = true;
            fullDescLabel.Location = new Point(34, 360);
            fullDescLabel.Name = "fullDescLabel";
            fullDescLabel.Size = new Size(63, 15);
            fullDescLabel.TabIndex = 10;
            fullDescLabel.Text = "Opis pełny";
            // 
            // fullDescTextBox
            // 
            fullDescTextBox.Location = new Point(138, 357);
            fullDescTextBox.Name = "fullDescTextBox";
            fullDescTextBox.Size = new Size(200, 23);
            fullDescTextBox.TabIndex = 11;
            // 
            // isAvailableLabel
            // 
            isAvailableLabel.AutoSize = true;
            isAvailableLabel.Location = new Point(382, 244);
            isAvailableLabel.Name = "isAvailableLabel";
            isAvailableLabel.Size = new Size(57, 15);
            isAvailableLabel.TabIndex = 12;
            isAvailableLabel.Text = "Dostępny";
            // 
            // isAvailableCheckBox
            // 
            isAvailableCheckBox.Location = new Point(486, 240);
            isAvailableCheckBox.Name = "isAvailableCheckBox";
            isAvailableCheckBox.Size = new Size(104, 24);
            isAvailableCheckBox.TabIndex = 13;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(382, 284);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(34, 15);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Cena";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(486, 281);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(200, 23);
            priceTextBox.TabIndex = 15;
            // 
            // discountPriceLabel
            // 
            discountPriceLabel.AutoSize = true;
            discountPriceLabel.Location = new Point(382, 324);
            discountPriceLabel.Name = "discountPriceLabel";
            discountPriceLabel.Size = new Size(62, 15);
            discountPriceLabel.TabIndex = 16;
            discountPriceLabel.Text = "Rabat w %";
            // 
            // discountPriceTextBox
            // 
            discountPriceTextBox.Location = new Point(486, 321);
            discountPriceTextBox.Name = "discountPriceTextBox";
            discountPriceTextBox.Size = new Size(200, 23);
            discountPriceTextBox.TabIndex = 17;
            // 
            // cuisineLabel
            // 
            cuisineLabel.AutoSize = true;
            cuisineLabel.Location = new Point(382, 364);
            cuisineLabel.Name = "cuisineLabel";
            cuisineLabel.Size = new Size(50, 15);
            cuisineLabel.TabIndex = 18;
            cuisineLabel.Text = "Kuchnia";
            // 
            // cuisineTextBox
            // 
            cuisineTextBox.Location = new Point(486, 361);
            cuisineTextBox.Name = "cuisineTextBox";
            cuisineTextBox.Size = new Size(200, 23);
            cuisineTextBox.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(672, 390);
            button2.Name = "button2";
            button2.Size = new Size(104, 44);
            button2.TabIndex = 20;
            button2.Text = "Dodaj Danie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSendData_ClickAsync;
            // 
            // AddDish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(uploadButton);
            Controls.Add(pictureBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(shortDescLabel);
            Controls.Add(shortDescTextBox);
            Controls.Add(fullDescLabel);
            Controls.Add(fullDescTextBox);
            Controls.Add(isAvailableLabel);
            Controls.Add(isAvailableCheckBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(discountPriceLabel);
            Controls.Add(discountPriceTextBox);
            Controls.Add(cuisineLabel);
            Controls.Add(cuisineTextBox);
            Name = "AddDish";
            Size = new Size(800, 600);
            Load += AddDish_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
        private Button uploadButton;
        private PictureBox pictureBox;
        private OpenFileDialog openFileDialog;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label shortDescLabel;
        private TextBox shortDescTextBox;
        private Label fullDescLabel;
        private TextBox fullDescTextBox;
        private Label isAvailableLabel;
        private CheckBox isAvailableCheckBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private Label discountPriceLabel;
        private TextBox discountPriceTextBox;
        private Label cuisineLabel;
        private Button button2;
        private TextBox cuisineTextBox;
        private string uploadedImageId;

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddDish_Load(object sender, EventArgs e)
        {

        }
    }
}

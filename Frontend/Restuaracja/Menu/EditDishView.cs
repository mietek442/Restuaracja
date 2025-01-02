using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.MenuView;

namespace Restuaracja.Menu
{
    public partial class EditDishView : Form
    {
        public EditDishView()
        {
            InitializeComponent();

        }

        public Dish selDish { get; set; }
        


        private void EditDishView_Load(object sender, EventArgs e)
        {
            label1.Text = selDish.name + " - Edycja dania";
            textBox1.Text = selDish.name;
            textBox2.Text = selDish.shortDescription;
            textBox3.Text = selDish.fullDescription;
            textBox4.Text = selDish.cuisine;
            checkBox1.Checked = selDish.isAvailable;
            textBox5.Text = selDish.price.ToString();
            textBox6.Text = selDish.discountPrice.ToString();

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(uploadedImageId))
            {
                var data = new
                {
                    name = textBox1.Text,
                    shortDescription = textBox2.Text,
                    fullDescription = textBox3.Text,
                    isAvailable = checkBox1.Checked,
                    price = decimal.Parse(textBox5.Text),
                    discountPrice = decimal.Parse(textBox6.Text),
                    cuisine = textBox4.Text,
                    imageId = uploadedImageId,
                };

                var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                MessageBox.Show($"Data to send:\n{jsonData}");

                using (var client = new HttpClient())
                {
                    var url = "https://localhost:5001/api/dishes/"+ selDish.id;
                    var response = await client.PutAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Danie zostało edytowane prawidłowo.");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie przesłano jeszcze obrazu.");
            }
        }
        private string uploadedImageId;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

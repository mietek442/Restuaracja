using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.GlobalConfig;

namespace Restuaracja.Supplies
{
    public partial class AddSupplies : UserControl
    {
        public AddSupplies()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = nameTextBox.Text,
                quantity = numericUpDown1.Text,
                unit = textBox1.Text,
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync($"{ApiBaseUrl}/supplies", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produkt został dodany prawidłowo.");
                }
                else
                {
                    string errContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"{errContent}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SuppliesView view = new SuppliesView();
            this.Controls.Add(view);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

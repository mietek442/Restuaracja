using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restuaracja.Supplies
{
    public partial class EditSupply : Form
    {
        public EditSupply()
        {
            InitializeComponent();
        }
        public Supply SupplyEdit { get; set; }
        private void EditSupply_Load(object sender, EventArgs e)
        {
            label1.Text = SupplyEdit?.name ?? "Edycja produktu";
            nameTextBox.Text = SupplyEdit?.name ?? "N/A";
            numericUpDown1.Value = SupplyEdit?.quantity ?? 0;
            textBox1.Text = SupplyEdit?.unit ?? "N/A";


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = nameTextBox.Text,
                quantity = numericUpDown1.Value,
                unit = textBox1.Text
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PutAsync($"https://localhost:5001/api/supplies/{SupplyEdit.id}", content);

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
    }
}

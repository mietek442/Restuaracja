using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace Restuaracja.Orders
{
    public partial class ChangeOrderStatus : Form
    {
        public Guid OrderID { get; set; }
        public ChangeOrderStatus()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var selectedStatus = comboBox1.SelectedItem.ToString();
            var data = new { id = OrderID, Status = selectedStatus };

            var jsonData = JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            MessageBox.Show($"Dane do wysłania : {jsonData}");

            using (var client = new HttpClient())
            {
                var url = $"https://localhost:5001/api/orders/status?id={OrderID}&Status={selectedStatus}";
                var response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Status zamówienia został zmieniony.");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }
    }
}

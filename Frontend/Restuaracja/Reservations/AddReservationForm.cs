using Restuaracja.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.ReservationsView;
using static Restuaracja.GlobalConfig;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restuaracja.Reservations
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();
        }

        public Table TableData { get; set; }
        private void AddReservationForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Rezerwacja dla stolika nr {TableData.tableNumber}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new
            {
                clientName = nameTextBox.Text,
                tableId = TableData.id,
                startTime = dateTimePicker1.Value.ToUniversalTime(),
                endTime = dateTimePicker1.Value.ToUniversalTime(),
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync($"{ApiBaseUrl}/reservations", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Rezerwacja została dodana prawidłowo.");
                }
                else
                {
                    string errContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"{errContent}");
                }
            }
        }
    }
}

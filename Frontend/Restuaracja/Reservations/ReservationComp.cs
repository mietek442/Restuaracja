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

namespace Restuaracja.Reservations
{
    public partial class ReservationComp : UserControl
    {
        public ReservationComp()
        {
            InitializeComponent();
        }

        private void endD_Click(object sender, EventArgs e)
        {

        }
        public TableReservation ReservationData { get; set; }

        private void ReservationComp_Load(object sender, EventArgs e)
        {
            client.Text = $"Imię klienta: {ReservationData.clientName}, {ReservationData.startTime} - {ReservationData.endTime}";
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.DeleteAsync($"{ApiBaseUrl}/reservations/{ReservationData.id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Pomyślnie usunięto rezerwację");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }

            }
            var parentControl = this.Parent;
            parentControl.Controls.Remove(this);
        }
    }
}

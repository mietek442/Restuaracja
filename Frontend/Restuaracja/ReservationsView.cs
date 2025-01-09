using Restuaracja.Components;
using Restuaracja.Reservations;
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
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class ReservationsView : UserControl
    {
        public ReservationsView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu mainMenu = new MainMenu();
            this.Controls.Add(mainMenu);
        }

        private async void ReservationsView_Load(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync($"{ApiBaseUrl}/tables");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var tables = JsonSerializer.Deserialize<List<Table>>(content);
                    foreach (var table in tables)
                    {
                        var tableItemControl = new TableComp
                        {
                            TableData = table
                        };
                        flowLayoutPanel1.Controls.Add(tableItemControl);
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Table {
            public Guid id { get; set; }
            public int tableNumber { get; set; }
            public int seatCount { get; set; }
            public string description { get; set; }
            public bool hasReservation { get; set; }
            public List<TableReservation> tableReservations { get; set; } = new List<TableReservation>();
        }
        public class TableReservation
        {
            public Guid id { get; set; }
            public string clientName { get; set; }
            public Guid tableId { get; set; }
            public Table table { get; set; }
            public DateTime startTime { get; set; }
            public DateTime endTime { get; set; }
        }
    }
}

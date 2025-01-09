using Restuaracja.Components;
using Restuaracja.Supplies;
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
using static Restuaracja.MenuView;
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class SuppliesView : UserControl
    {
        public SuppliesView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            this.Controls.Add(menu);
        }

        private async void SuppliesView_Load(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync($"{ApiBaseUrl}/supplies");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var supplies = JsonSerializer.Deserialize<List<Supply>>(content);
                    foreach (var supply in supplies)
                    {
                        var supplyItemControl = new SupplyComp
                        {
                            SupplyData = supply
                        };
                        flowLayoutPanel1.Controls.Add(supplyItemControl);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AddSupplies add = new AddSupplies();
            this.Controls.Add(add);
        }
    }
    public class Supply
    {
        public Guid id { get; set; }
        public string name { get; set; }    
        public int quantity { get; set; }
        public string unit { get; set; }
    }
}

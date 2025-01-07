using Restuaracja.Components;
using Restuaracja.Orders;
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
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            this.Controls.Add(menu);
        }

        private async void OrdersView_Load(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync($"{ApiBaseUrl}/dishes");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var dishes = JsonSerializer.Deserialize<List<DishInOrder>>(content);
                    foreach (var dish in dishes)
                    {
                        var dishOrderItemControl = new DishOrderComp
                        {
                            DishData = dish
                        };
                        flowLayoutPanel1.Controls.Add(dishOrderItemControl);
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            OrderComp orderComp = new OrderComp();
            this.Controls.Add(orderComp);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class DishInOrder
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public string cuisine { get; set; }
        public bool isAvailable { get; set; }
        public decimal? price { get; set; }
        public decimal? discountPrice { get; set; }
        public decimal finalPrice { get; set; }
        public string imgUrl { get; set; }
        public string size { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restuaracja.Components;
using Restuaracja.Menu;
using static Restuaracja.MenuView;
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            this.Controls.Add(menu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AddDish addProduct = new AddDish();
            this.Controls.Add(addProduct);
        }


        private async void MenuView_Load(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync($"{ApiBaseUrl}/dishes");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var dishes = JsonSerializer.Deserialize<List<Dish>>(content);
                    foreach (var dish in dishes)
                    {
                        var dishItemControl = new DishComp
                        {
                            DishData = dish
                        };
                        flowLayoutPanel1.Controls.Add(dishItemControl);
                    }
                }
                else {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Dish
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
}

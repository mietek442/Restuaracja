using Microsoft.VisualBasic.ApplicationServices;
using Restuaracja.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ReservationsView reservationsView = new ReservationsView();
            this.Controls.Add(reservationsView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SuppliesView suppliesView = new SuppliesView();
            this.Controls.Add(suppliesView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MenuView menuView = new MenuView();
            this.Controls.Add(menuView);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            OrdersView ordersView = new OrdersView();
            this.Controls.Add(ordersView);
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{ApiBaseUrl}/user/login");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var user = JsonSerializer.Deserialize<ResteurantUser>(content);

                    if (user.isAdmin)
                    {
                        button5.Text = user.name + " " + " Admin";
                        button6.Visible = true;
                    }
                    else
                    {
                        button6.Visible = true;
                        button5.Text = user.name + " " + " User";
                    }
                }
                else
                {
                    button6.Visible = false;
                    button5.Text = "Zaloguj";
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            this.Controls.Add(userControl1);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                // pusty musi być content
                var content = new StringContent(string.Empty);
                var response = await client.PostAsync($"{ApiBaseUrl}/user/logout", content);
                if (response.IsSuccessStatusCode)
                {
                    
                    MessageBox.Show("Pomyślnie Wylogowano");
                }
                
            }
        }
    }
    public class ResteurantUser
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string hashedPassword { get; set; }
        public bool isAdmin { get; set; }
        public bool isLogin { get; set; }
    }
}

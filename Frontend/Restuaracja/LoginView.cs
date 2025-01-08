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
using static Restuaracja.MenuView;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Restuaracja.GlobalConfig;

namespace Restuaracja
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;
            string pass= passInput.Text;

            var user = new {
                name = login,
                password = pass,
            };

            using (var client = new System.Net.Http.HttpClient())
            {
                var jsonData = System.Text.Json.JsonSerializer.Serialize(user);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{ApiBaseUrl}/user/login",content);
                if (response.IsSuccessStatusCode)
                {
                    this.Controls.Clear();
                    MainMenu menu = new MainMenu();
                    Controls.Add(menu);
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

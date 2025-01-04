using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuaracja.User
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = textBox1.Text,
                password = textBox2.Text,
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync("https://localhost:5001/api/user/login", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Użytkownik został zalogowany");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }

        }
        private async void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            this.Controls.Add(userControl2);
        }
         private async void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MenuView menuView = new MenuView();
            this.Controls.Add(menuView);
        }

    }
}

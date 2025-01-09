using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.GlobalConfig;

namespace Restuaracja.User
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = textBox1.Text,
                hashedPassword = textBox2.Text,
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync($"{ApiBaseUrl}/users/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Użytkownik został Zarejstrowany");
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
            UserControl1 userControl1 = new UserControl1();
            this.Controls.Add(userControl1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            LoginView mainMenu = new LoginView();
            this.Controls.Add(mainMenu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuaracja.Orders
{
    public partial class OrderComp : UserControl
    {
        public OrderComp()
        {
            InitializeComponent();
        }

        private async void OrderComp_Load(object sender, EventArgs e)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync("https://localhost:5001/api/orders");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Dane pobrane: {content}");
                    var orders = JsonSerializer.Deserialize<List<Order>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        IncludeFields = true
                    });

                    foreach (var order in orders)
                    {
                      
                        var orderItemControl = new OrderLabel
                        {
                            OrderData = order
                        };

                        flowLayoutPanel1.Controls.Add(orderItemControl);
                    }

                    
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            OrdersView add = new OrdersView();
            this.Controls.Add(add);
        }
    }

    public class Order
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public string status { get; set; }
        public decimal price { get; set; }
    }

    public class OrderItem
    {
        public Guid id { get; set; }
        public Guid orderId { get; set; }
        public Guid dishId { get; set; }
        public string dishName { get; set; }
      

        public Dish dish { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
    }

    public class Dish
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public string cuisine { get; set; }
        public bool isAvailable { get; set; }
        public decimal price { get; set; }
        public decimal discountPrice { get; set; }
        public Guid imageId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

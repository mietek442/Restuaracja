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

namespace Restuaracja
{
    public partial class OrdersView : UserControl
    {
        private string connectionString;
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

        private async void Sprawdz_Click(object sender, EventArgs e)
        {
            var checkedDishes = new List<SelectedDish>();
            var DishCompLIst = flowLayoutPanel1.Controls;
            foreach (Control control in DishCompLIst)
            {
                if (control is DishOrderComp dishOrderComp)
                {
                    var checkBox = dishOrderComp.CheckBox1;
                    var dishData = dishOrderComp.DishData;

                    if (checkBox.Checked)
                    {
                        var selectedDish = new SelectedDish
                        {
                            dishId = dishOrderComp.DishData.id,
                            quantity = (int)dishOrderComp.NumericUpDown1.Value,
                            dishPrice = dishOrderComp.DishData.finalPrice 
                        }; 


                        checkedDishes.Add(selectedDish);
                      
                    }
                }
            }
            var responeOrder = new
            {
                orderItems = checkedDishes.Select(dish => new
                {
                    dish.dishId,
                    dish.quantity,
                    dish.dishPrice
                }).ToList()
            };

            
            var json = JsonSerializer.Serialize(responeOrder);
           

            if (checkedDishes.Count > 0)
            {

                using (var client = new System.Net.Http.HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    MessageBox.Show(json);
                    var response = await client.PostAsync("https://localhost:5001/api/orders", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var orderResponse = JsonSerializer.Deserialize<OrderResponse>(responseContent);

                        MessageBox.Show($"Kwota Zamówienia: {orderResponse.price} zł\nZamówienie zostało utworzone dnia: {orderResponse.id}");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }





              
            }
            else
            {
                MessageBox.Show("No dishes selected.");
            }
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
    public class SelectedDish
    {
        public Guid dishId { get; set; }
        public int quantity { get; set; }
        public decimal dishPrice { get; set; }
    }

    public class OrderResponse
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public List<OrderItemResponse> orderItems { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string status { get; set; }
        public decimal price { get; set; }
    }

    public class OrderItemResponse
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid DishId { get; set; }
        public Dish Dish { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }


}
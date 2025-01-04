using System;
using System.Windows.Forms;

namespace Restuaracja.Orders
{
    public partial class OrderLabel : UserControl
    {
        public OrderLabel()
        {
            InitializeComponent();
        }

        public Order OrderData { get; set; }

        private void OrderLabel_Load(object sender, EventArgs e)
        {
            if (OrderData != null)
            {
                labelUpdatedAt.Text = $"ID Zamówienia: {OrderData.id}";
                labelCreatedAt.Text = $"ID zamawiajacego: {OrderData.userId}";
                labelStatus.Text = $"Status: {OrderData.status}";
                OrderPrice.Text = $"Cena Sumaryczna: {OrderData.price:C}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MessageBox.Show("Order Items");
            foreach (var orderItem in OrderData.orderItems)
            {
               
                var orderItemView = new OrderItemView
                {
                    OrderItemData = orderItem
                };

                flowLayoutPanel1.Controls.Add(orderItemView);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

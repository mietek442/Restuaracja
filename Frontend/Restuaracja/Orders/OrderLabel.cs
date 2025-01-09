using Restuaracja.Menu;
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
                labelCreatedAt.Text = $"ID Zamówienia: {OrderData.id}";
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
            foreach (var orderItem in OrderData.orderItems)
            {
                var orderItemView = new OrderItemView
                {
                    OrderItemData = orderItem
                };
                flowLayoutPanel1.Controls.Add(orderItemView);
                AdjustLayout();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus edit = new ChangeOrderStatus { OrderID = OrderData.id };
            edit.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ChangeOrderStatus edit = new ChangeOrderStatus { OrderID = OrderData.id };
            edit.Show();
        }
    }
}

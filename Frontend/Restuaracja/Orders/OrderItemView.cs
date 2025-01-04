using System;
using System.Windows.Forms;

namespace Restuaracja.Orders
{
    public partial class OrderItemView : UserControl
    {
        public OrderItemView()
        {
            InitializeComponent();
        }

        public OrderItem OrderItemData { get; set; }

        private void OrderItemView_Load(object sender, EventArgs e)
        {
            if (OrderItemData != null)
            {
                labelDishId.Text = $"Danie: {OrderItemData.dish.name}";
                labelQuantity.Text = $"Ilosć: {OrderItemData.quantity}";
                labelTotalPrice.Text = $"Cena Sumaryczna: {OrderItemData.totalPrice:C}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}

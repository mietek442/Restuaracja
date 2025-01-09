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
            if (OrderItemData != null && OrderItemData.dish != null)
            {
                labelDishId.Text = $"Danie: {OrderItemData.dishName}";
                labelQuantity.Text = $"Ilość: {OrderItemData.quantity}";
                labelTotalPrice.Text = $"Cena Sumaryczna: {OrderItemData.totalPrice} zł";
            }
            else
            {
                MessageBox.Show("Order item or dish data is missing.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

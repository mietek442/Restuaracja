using Restuaracja.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restuaracja.ReservationsView;

namespace Restuaracja.Reservations
{
    public partial class TableComp : UserControl
    {
        public TableComp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Table TableData { get; set; }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TableComp_Load(object sender, EventArgs e)
        {
            label1.Text = $"Numer stolika: {TableData.tableNumber}";
            label2.Text = $"Liczba miejsc: {TableData.seatCount}";
            label3.Text = $"{TableData.description}";
            status.Text = TableData.hasReservation ? "Rezerwacja" : "Wolny";



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReservationForm comp = new ReservationForm { TableData = TableData };
            comp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

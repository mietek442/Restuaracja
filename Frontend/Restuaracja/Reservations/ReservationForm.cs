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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Table TableData { get; set; }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            label3.Text = $"Rezerwacje dla stolika nr. {TableData.tableNumber}";
            foreach (var reservation in TableData.tableReservations)
            {
                var reservationItemControl = new ReservationComp
                {
                    ReservationData = reservation
                };
                flowLayoutPanel1.Controls.Add(reservationItemControl);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddReservationForm comp = new AddReservationForm{ TableData = TableData };
            comp.Show();
        }
    }
}

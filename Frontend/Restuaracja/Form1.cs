using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restuaracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Usuni�cie niepotrzebnego wyj�cia z aplikacji podczas malowania
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obs�uga dla "Zaopatrzenie"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Obs�uga dla "Stoliki"
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obs�uga dla "Zasrana Resteuracja"
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Obs�uga dla "Jeste� Peda�em"
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
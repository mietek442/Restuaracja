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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();

            this.Controls.Add(mainMenu);

            this.ClientSize = mainMenu.Size;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

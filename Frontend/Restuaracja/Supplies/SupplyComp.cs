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

namespace Restuaracja.Supplies
{
    public partial class SupplyComp : UserControl
    {
        public SupplyComp()
        {
            InitializeComponent();
        }
        public Supply SupplyData { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            EditSupply edit = new EditSupply { SupplyEdit = SupplyData };
            edit.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SupplyComp_Load(object sender, EventArgs e)
        {
            string txtContent = $"{SupplyData?.name ?? "N/A"}, Ilość: {SupplyData?.quantity ?? 0} {SupplyData?.unit ?? "N/A"}";
            label1.Text = txtContent;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5138/api/supplies/{SupplyData.id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Danie zostało usunięte.");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }
    }
}

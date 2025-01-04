using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using static Restuaracja.MenuView;
using Restuaracja.Menu;

namespace Restuaracja.Components
{
    public partial class DishComp : UserControl
    {
        public DishComp()
        {
            InitializeComponent();
        }
        public string DishName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string DishPrice
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string DishDescription
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string DishImage
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        public Dish DishData { get; set; }

        private async void DishComp_Load(object sender, EventArgs e)
        {
            label1.Text = DishData?.name ?? "N/A";
            label2.Text = DishData?.finalPrice.ToString() + " zł" ?? "N/A";
            label3.Text = DishData?.shortDescription ?? "N/A";
            pictureBox1.ImageLocation = DishData?.imgUrl ?? "N/A";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDishView edit = new EditDishView { selDish = DishData };
            edit.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient()) {
                var response =  await client.DeleteAsync($"https://localhost:5001/api/dishes/{DishData.id}");
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

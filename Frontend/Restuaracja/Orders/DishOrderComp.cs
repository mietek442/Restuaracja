using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuaracja.Orders
{
    public partial class DishOrderComp : UserControl
    {
        public DishOrderComp()
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
        public NumericUpDown NumericUpDown1 { get { return numericUpDown1; } }
        public CheckBox CheckBox1 { get { return checkBox1; } }
        public DishInOrder DishData { get; set; }

        private void DishOrderComp_Load(object sender, EventArgs e)
        {
            label1.Text = DishData?.name ?? "N/A";
            label2.Text = DishData?.finalPrice.ToString() + " zł" ?? "N/A";
            label3.Text = DishData?.shortDescription ?? "N/A";
            pictureBox1.ImageLocation = DishData?.imgUrl ?? "N/A";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    public partial class UserControlShoe : UserControl
    {
        public UserControlShoe()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMan.Checked)
            {
                comboBoxShoeType.SelectedItem = null;
                comboBoxShoeType.Items.Clear();
                comboBoxShoeType.Items.AddRange(new object[]{ "Oxfords", "Derby shoes", "Loafers", "Brogues", "Monk strap shoes", "Dress boots", "Boat shoes", "Chelsea boots", "Chukka boots", "Wingtip shoes", "Moccasins" });
            }
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWoman.Checked)
            {
                comboBoxShoeType.SelectedItem = null;
                comboBoxShoeType.Items.Clear();
                comboBoxShoeType.Items.AddRange(new object[] {
                   "Pumps",
                   "Ballet flats",
                   "Ankle boots",
                   "Wedges",
                   "Espadrilles",
                   "Mules",
                   "Gladiator sandals",
                   "High heels",
                   "Platform shoes",
                   "Slingback shoes" });
            }
        }

        private void radioButtonUnisex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUnisex.Checked)
            {
                comboBoxShoeType.SelectedItem = null;
                comboBoxShoeType.Items.Clear();
                comboBoxShoeType.Items.AddRange(new object[] {"Sneakers", "Athletic shoes", "Hiking boots", "Sandals" ,"Flip-flops" });
            }
        }

        public Shoe backToTheAdd()
        {

            string gender;
            double size;
            double price;
            string type;
            string brand;
            string color;

            if (radioButtonMan.Checked)
            {
                gender = radioButtonMan.Text;//gender=  "man"
            }
            else if (radioButtonWoman.Checked)
            {
                gender = radioButtonWoman.Text;
            }
            else if (radioButtonUnisex.Checked)
            {
                gender = radioButtonUnisex.Text;
            }
            else
            {
                MessageBox.Show("please fill gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            type = comboBoxShoeType.SelectedItem?.ToString();

            color = comboBoxColor.SelectedItem?.ToString();//if empty it insert to    color = ""
            brand = textBoxBrand.Text;
           

            if (color == null || brand == "" || type == null)
            {
                MessageBox.Show("please fill everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            if (!(double.TryParse(comboBoxShoeSize.SelectedItem?.ToString(), out size)))
            {
                
                MessageBox.Show("please fill size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            if (!(double.TryParse(textBoxPrice.Text, out price)))
            {
                string errorMessage = "Input should be a number.";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Shoe("Shoe", gender, color, brand, price,size, type);
        }

        public void clear()
        {
            comboBoxShoeType.SelectedItem = null;
            comboBoxShoeSize.SelectedItem = null;
            textBoxBrand.Text = "";
            comboBoxShoeSize.SelectedItem= null;
            textBoxPrice.Text = "";
            radioButtonMan.Checked = false;
            radioButtonWoman.Checked = false;
            radioButtonUnisex.Checked = false;

        }

        public void updatePannel(string type, string gender, string brand, string color, string price, string size)
        {
            if (gender == radioButtonMan.Text)
                radioButtonMan.Checked = true;
            else if (gender == radioButtonWoman.Text)
                radioButtonWoman.Checked = true;
            else if (gender == radioButtonUnisex.Text)
                radioButtonUnisex.Checked = true;

            comboBoxShoeType.SelectedItem = type;
            comboBoxShoeSize.SelectedItem = size;
            textBoxBrand.Text = brand;
            comboBoxShoeSize.SelectedItem = size;
            textBoxPrice.Text = price;
        }
    }
    
}

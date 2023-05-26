using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal.userControls
{
    public partial class UserControlShirt : UserControl
    {
        public UserControlShirt()
        {
            InitializeComponent();
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMan.Checked)
            {

                comboBoxShirtType.SelectedItem = null;
                comboBoxShirtType.Items.Clear();
                comboBoxShirtType.Items.AddRange(new object[] {
                "Dress Shirt",
                "Hawaiian Shirt",
                "Rugby Shirt",
                "Button-Down Shirt",
                "Flannel Shirt",
                "Corduroy Shirt",
                "Bowling Shirt",
                "Muscle Shirt",
                "Performance Shirt",
                "Fishing Shirt",
                "Guayabera Shirt"});
            };
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWoman.Checked)
            {
                comboBoxShirtType.SelectedItem = null;
                comboBoxShirtType.Items.Clear();
                comboBoxShirtType.Items.AddRange(new object[] {
                "Henley Shirt",
                "Flannel Shirt",
                "Tunic Shirt",
                "Peplum Top",
                "Wrap Shirt",
                "Kimono Top",
                "Oversized Blouse",
                "Crop Top",
                "Ruffled Shirt",
                "Sheer Shirt",
                "High-Low Hem Shirt",
                "Peasant Top" });
            }
        }

        private void radioButtonUnisex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUnisex.Checked)
            {
                comboBoxShirtType.SelectedItem = null;
                comboBoxShirtType.Items.Clear();
                comboBoxShirtType.Items.AddRange(new object[] {
                "Dress Shirt",
                "Hawaiian Shirt",
                "Sweatshirt",
                "Hoodie",
                "Peplum Top",
                "Kimono Top",
                "Oversized Blouse",
                "Crop Top",
                "Ruffled Shirt",
                "Sheer Shirt",
                "High-Low Hem Shirt",
                "Peasant Top" });
            }
        }




        public Shirt backToTheAdd()
        {

            string gender;

            if (radioButtonMan.Checked)
                gender = radioButtonMan.Text;
            else if (radioButtonWoman.Checked)
                gender = radioButtonWoman.Text;
            else if (radioButtonUnisex.Checked)
                gender = radioButtonUnisex.Text;
            else
            {
                MessageBox.Show("please fill gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            string fabric = (comboBoxFabric.SelectedItem)?.ToString();
            string type = (comboBoxShirtType.SelectedItem)?.ToString();
            string size = (comboBoxShirtSize.SelectedItem)?.ToString();
            //the question mark ?. is a operator that checks if the left side of ?. is null ,if yes it skips the right part and returns null
            string color = (comboBoxColor.SelectedItem)?.ToString();
            string brand = textBoxBrand.Text;

            if (type == null || size == null || fabric==null || color == null || brand == "")
            {
                MessageBox.Show("please fill everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //double price = Double.Parse(textBoxPrice.Text);



            double price = 0;
            int i = 0;
            if (!(double.TryParse(textBoxPrice.Text, out price)))
            {
                string errorMessage = "Input should be a number.";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }



            Shirt temp = new Shirt("Shirt", gender, color, brand, price, fabric, size, type);
            return temp;


        }
        public void clear()
        {
            comboBoxShirtType.SelectedItem = null;
            comboBoxShirtSize.SelectedItem = null;
            comboBoxFabric.SelectedItem = null;
            textBoxBrand.Text = "";
            comboBoxColor.SelectedItem= null;
            textBoxPrice.Text = "";
            radioButtonMan.Checked = false;
            radioButtonWoman.Checked = false;
            radioButtonUnisex.Checked = false;

        }

 

        public void updatePannel(string fabric, string type, string gender, string brand, string color, string price, string size)
        {
            if (gender == radioButtonMan.Text)
                radioButtonMan.Checked = true;
            else if (gender == radioButtonWoman.Text)
                radioButtonWoman.Checked = true;
            else if (gender == radioButtonUnisex.Text)
                radioButtonUnisex.Checked = true;
            comboBoxFabric.SelectedItem = fabric;

            comboBoxShirtType.SelectedItem = type;
            comboBoxShirtSize.SelectedItem = size;
            textBoxBrand.Text = brand;
            comboBoxColor.SelectedItem = color;
            textBoxPrice.Text = price;
        }
    }
}

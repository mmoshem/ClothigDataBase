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
            else
                gender = radioButtonUnisex.Text;

            string type = comboBoxShirtType.SelectedItem.ToString();

            string size = comboBoxShirtSize.SelectedItem.ToString();
            string color = textBoxColor.Text;
            string brand = textBoxBrand.Text;
            //double price = Double.Parse(textBoxPrice.Text);
            double price = 0;
            int i = 0;
            while (i == 0)
            {
                if (double.TryParse(textBoxPrice.Text, out price)) { i = 1; }
                else
                {
                    string errorMessage = "Input should be a number.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Shirt temp = new Shirt("Shirt", gender, color, brand, price, "none", size, type);
            return temp;

        }
    }
}

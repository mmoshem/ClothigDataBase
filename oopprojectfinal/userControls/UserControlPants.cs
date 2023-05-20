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
    public partial class UserControlPants : UserControl
    {
        public UserControlPants()
        {
            InitializeComponent();
            
        }

        private void UserControlPants_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonMan.Checked)
            {
                
                comboBoxPantsType.SelectedItem = null;
                comboBoxPantsType.Items.Clear();
                comboBoxPantsType.Items.AddRange(new object[] {
                "Jeans",
                "Chinos",
                "Cargo pants",
                "Sweatpants",
                "Trousers",
                "Harem pants",
                "Track pants",
                "Dress pants",
                "Khaki pants",
                "Corduroy pants",
                "Pleated pants",
                "Jogger pants",
                "Skinny pants"});
                };
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWoman.Checked)
            {
                comboBoxPantsType.SelectedItem = null;
                comboBoxPantsType.Items.Clear();////////////////////////////////////////////////not influencing ?
                comboBoxPantsType.Items.AddRange(new object[] {
                "Jeans",
                "Chinos",
                "Leggings",
                "Capri pants",
                "Palazzo pants",
                "Culottes",
                "Trousers",
                "High-waisted pants",
                "Bootcut pants",
                "Wide-leg pants",
                "Paperbag pants",
                "Flare pants",
                "Cropped pants"});
            }
        }
        private void radioButtonUnisex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUnisex.Checked)
            {
                comboBoxPantsType.SelectedItem = null;
                comboBoxPantsType.Items.Clear();
                comboBoxPantsType.Items.AddRange(new object[] {
                "Sweatpants",
                "Jeggings",
                "Yoga pants",
                "Track pants",
                "Cargo shorts",
                "Overall pants",
                "Bike shorts",
                "Boardshorts",
                "Snow pants",
                "Windbreaker pants"});
            }
        }

        public Pants backToTheAdd()
        {

            string gender;
            if (radioButtonMan.Checked)
                gender = radioButtonMan.Text;
            else if (radioButtonWoman.Checked)
                gender = radioButtonWoman.Text;
            else 
                gender = radioButtonUnisex.Text;

            string type = comboBoxPantsType.SelectedItem.ToString();

            string size = comboBoxPantsSize.SelectedItem.ToString();
            string color = textBoxColor.Text;
            string brand = textBoxBrand.Text;
            //double price = Double.Parse(textBoxPrice.Text);
            double price=0;
            int i=0;
            while (i == 0)
            {
                if(double.TryParse(textBoxPrice.Text,out price)) { i = 1; }            
                else
                {
                    string errorMessage = "Input should be a number.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Pants temp = new Pants("Pants",gender,color,brand,price,"none",size,"fat");
            return temp;

        }

    }
}

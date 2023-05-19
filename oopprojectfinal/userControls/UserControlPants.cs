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
                comboBoxPantsType.Items.Clear();
                comboBoxPantsType.Items.AddRange(new object[] {
                "woman be gae"});
            };
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
            double price = Double.Parse(textBoxPrice.Text);
            Pants temp = new Pants("Pants",gender,color,brand,price,"none",size,"fat");
            return temp;

        }
    }
}

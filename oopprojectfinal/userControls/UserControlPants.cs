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
                gender = radioButtonMan.Text; //Man
            else if (radioButtonWoman.Checked)
                gender = radioButtonWoman.Text;
            else if (radioButtonUnisex.Checked)
                gender = radioButtonUnisex.Text;
            else
            {
                MessageBox.Show("please fill gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            
            string type = (comboBoxPantsType.SelectedItem)?.ToString();
            string size = (comboBoxPantsSize.SelectedItem)?.ToString();
            string fabric = (comboBoxPantsFabric.SelectedItem)?.ToString();
            //the question mark ?. is a operator that checks if the left side of ?. is null ,if yes it skips the right part and returns null
            string color = (comboBoxColor.SelectedItem)?.ToString(); 
            string brand = textBoxBrand.Text;

            if(type == null || size== null || fabric == null || color==null || brand=="")
            {
                MessageBox.Show("please fill everything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            
           
            
            
            double price=0;
          
            if(! (double.TryParse(textBoxPrice.Text,out price)))            
            {
                string errorMessage = "Input should be a number.";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            

            Pants temp = new Pants("Pants",gender,color,brand,price,fabric,size,type);
            return temp;

        }
        public void clear()
        {
            comboBoxPantsType.SelectedItem = null;
            comboBoxPantsSize.SelectedItem = null;
            comboBoxPantsFabric.SelectedItem = null;
            textBoxBrand.Text = "";
            comboBoxColor.SelectedItem = null;
            textBoxPrice.Text = "";
            radioButtonMan.Checked = false;
            radioButtonWoman.Checked = false;
            radioButtonUnisex.Checked = false;

        }
        public void updatePannel(string fabric,string type ,string gender,string brand,string color,string price,string size)
        {
            if (gender == radioButtonMan.Text)
                radioButtonMan.Checked = true;
            else if (gender == radioButtonWoman.Text)
                radioButtonWoman.Checked = true;
            else if (gender == radioButtonUnisex.Text)
                radioButtonUnisex.Checked = true;
            comboBoxPantsFabric.SelectedItem = fabric;

            comboBoxPantsType.SelectedItem = type;
            comboBoxPantsSize.SelectedItem = size;
            textBoxBrand.Text = brand;
            comboBoxColor.SelectedItem = color;
            textBoxPrice.Text = price;

            
        }
    }
}

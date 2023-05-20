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
                comboBoxShoeSize.Items.AddRange(new object[]{ "Oxfords", "Derby shoes", "Loafers", "Brogues", "Monk strap shoes", "Dress boots", "Boat shoes", "Chelsea boots", "Chukka boots", "Wingtip shoes", "Moccasins", "Flip-flops", "Athletic shoes", "Hiking boots" });
            }
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWoman.Checked)
            {
                comboBoxShoeType.SelectedItem = null;
                comboBoxShoeType.Items.Clear();
                comboBoxShoeSize.Items.AddRange(new object[] {
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
                comboBoxShoeSize.Items.AddRange(new object[] {"Sneakers","Sandals"});
            }
        }
    }
    
}

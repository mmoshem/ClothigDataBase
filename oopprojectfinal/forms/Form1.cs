using oopprojectfinal.userControls;
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
 
    public partial class Form1 : Form
    {
        BindingList<Clothing> ClothingTable= new BindingList<Clothing>();
        BindingList<Pants> PantsTable= new BindingList<Pants>();
        BindingList<Shirt> ShirtTable= new BindingList<Shirt>();
        BindingList<Shoe> ShoeTable= new BindingList<Shoe>();

        UserControlPants userPants = null;
        UserControlShirt userShirt = null;
        UserControlShoe userShoe = null;


        public Form1()
        {
            InitializeComponent();
            
        }




        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();

            userShoe = null; 
            userShirt = null;
            userPants = null;

            if (comboBoxItem.SelectedItem.ToString() == "Shoe")
            {

                // Create a new instance of the UserControlShoe
                UserControlShoe userControlShoe = new UserControlShoe();
                
                panelForm.Controls.Add(userControlShoe);

                userShoe = userControlShoe;

                dataGrid.DataSource = ShoeTable;

            }
            if(comboBoxItem.SelectedItem.ToString() == "Shirt")
            {
                dataGrid.DataSource = ShirtTable;

                // Create a new instance of the userControlShirt
                UserControlShirt userControlShirt = new UserControlShirt();

                panelForm.Controls.Add(userControlShirt);

                userShirt = userControlShirt;

            }
            if (comboBoxItem.SelectedItem.ToString() == "Pants")
            {
                

                // Create a new instance of the userControlPants
                userPants = new UserControlPants();

                panelForm.Controls.Add(userPants);

                dataGrid.DataSource = PantsTable;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // i want to make a pure virtual function add in clothes and override the function in pants and shirt its for the polymorfizem and also for not writing userPants.backtotheadd instead to write pants.add or shirt.add
            if (userPants != null)
            {
                Pants tmp = userPants.backToTheAdd();
                PantsTable.Add(tmp);
            }
            if (userShirt != null)
            {
                Shirt tmp = userShirt.backToTheAdd();
                ShirtTable.Add(tmp);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGrid.DataSource == userPants)
            {
                
            }
        }
        //////////////////////

    }
}

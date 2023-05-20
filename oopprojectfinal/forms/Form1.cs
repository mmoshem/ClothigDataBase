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

                dataGrid.DataSource = ShoeTable;
                // Create a new instance of the UserControlShoe
                UserControlShoe userControlShoe = new UserControlShoe();
                // Add the UserControlShoe to the panel
                panelForm.Controls.Add(userControlShoe);

                userShoe = userControlShoe;


            }
            if(comboBoxItem.SelectedItem.ToString() == "Shirt")
            {
                dataGrid.DataSource = ShirtTable;

                // Create a new instance of the userControlShirt
                UserControlShirt userControlShirt = new UserControlShirt();

                // Add the userControlShirt to the panel
                panelForm.Controls.Add(userControlShirt);

                userShirt = userControlShirt;

            }
            if (comboBoxItem.SelectedItem.ToString() == "Pants")
            {
                

                // Create a new instance of the userControlPants
                userPants = new UserControlPants();

                // Add the userControlPants to the panel
                panelForm.Controls.Add(userPants);

                dataGrid.DataSource = PantsTable;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (userPants != null)
            {
                Pants tmp = userPants.backToTheAdd();
                PantsTable.Add(tmp);
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

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

        DataGridViewRow selectedRow;

        public Form1()
        {
            InitializeComponent();
            
        }




        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            selectedRow = null;
            userShoe = null; 
            userShirt = null;
            userPants = null;

            if (comboBoxItem.SelectedItem.ToString() == "Shoe")
            {

                // Create a new instance of the UserControlShoe
                userShoe  = new UserControlShoe();
                
                panelForm.Controls.Add(userShoe);

                dataGrid.DataSource = ShoeTable;

            }
            if(comboBoxItem.SelectedItem.ToString() == "Shirt")
            {
                dataGrid.DataSource = ShirtTable;

                // Create a new instance of the userControlShirt
                userShirt = new UserControlShirt();

                panelForm.Controls.Add(userShirt);


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
            
            if (userPants != null)
            {
                Pants tmp = userPants.backToTheAdd();
                if(tmp != null)
                    PantsTable.Add(tmp);
            }
            if (userShirt != null)
            {
                Shirt tmp = userShirt.backToTheAdd();
                if(tmp != null)
                    ShirtTable.Add(tmp);
            }
            if (userShoe != null)
            {
                Shoe tmp = userShoe.backToTheAdd();
                if (tmp != null)
                    ShoeTable.Add(tmp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

           
            if (selectedRow!=null)
            {
                if (userPants != null)
                {
                    Pants tmp=userPants.backToTheAdd();

                    PantsTable[selectedRow.Index] = tmp;
                }   

            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (userPants != null)
            {
                selectedRow = dataGrid.Rows[e.RowIndex];

                // Retrieve the values from specific cells in the row
                
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string type = selectedRow.Cells["pantsType"].Value.ToString();
                string size = selectedRow.Cells["clothesSize"].Value.ToString();
                string fabric = selectedRow.Cells["fabricType"].Value.ToString();
                string color = selectedRow.Cells["color"].Value.ToString();
                string brand = selectedRow.Cells["brand"].Value.ToString();
                //double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                string price = selectedRow.Cells["price"].Value.ToString();
                userPants.updatePannel(fabric,type, gender, brand, color, price, size);
            }
            if (userShirt != null)
            {

            }
            if (userShoe != null)
            {

            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(userPants!=null)
                userPants.clear();
            if (userShoe != null)
                userShoe.clear();
            if (userShirt != null)
                userShirt.clear();
        }

        //////////////////////

    }
}

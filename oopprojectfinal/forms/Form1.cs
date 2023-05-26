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
        BindingList<Clothing> ClothingTable = new BindingList<Clothing>();
        BindingList<Pants> PantsTable = new BindingList<Pants>();
        BindingList<Shirt> ShirtTable = new BindingList<Shirt>();
        BindingList<Shoe> ShoeTable = new BindingList<Shoe>();

        UserControlPants userPants = null;
        UserControlShirt userShirt = null;
        UserControlShoe userShoe = null;

        DataGridViewRow selectedRow;
        List<PictureBox> pbLsit = new List<PictureBox>();

        bool isMouseClicked = false;
        bool mouseLeft = false;
        bool mouseRight = false;

        public Form1()
        {
            InitializeComponent();

            Pants tmp = new Pants("Pants", "Man", "tahat", "Nintendo", 123, "Silk", "M", "Cargo pants");
            PantsTable.Add(tmp);
            tmp.pb.MouseDown += pic_MouseDown;
            tmp.pb.MouseMove += pic_MouseMove;
            tmp.pb.MouseUp += pic_MouseUp;
            tmp.pb.Location = new Point(0, 0);
            pbLsit.Add(tmp.pb);
            pictureHolder.Controls.Add(tmp.pb);//the "this" is the form

            tmp = new Pants("Pants", "Woman", "tahat", "Nintendo", 321, "Linen", "XL", "Culottes");
            PantsTable.Add(tmp);
            tmp.pb.MouseDown += pic_MouseDown;
            tmp.pb.MouseMove += pic_MouseMove;
            tmp.pb.MouseUp += pic_MouseUp;
            tmp.pb.Location = new Point(0, 0);
            pbLsit.Add(tmp.pb);
            pictureHolder.Controls.Add(tmp.pb);//the "this" is the form
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
                userShoe = new UserControlShoe();

                panelForm.Controls.Add(userShoe);

                dataGrid.DataSource = ShoeTable;

            }
            if (comboBoxItem.SelectedItem.ToString() == "Shirt")
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
                if (tmp != null)
                {
                    PantsTable.Add(tmp);
                    ClothingTable.Add(tmp);

                    tmp.pb.MouseDown += pic_MouseDown;
                    tmp.pb.MouseMove += pic_MouseMove;
                    tmp.pb.MouseUp += pic_MouseUp;

                    pbLsit.Add(tmp.pb);
                    pictureHolder.Controls.Add(tmp.pb);//the "this" is the form
                }

            }
            if (userShirt != null)
            {
                Shirt tmp = userShirt.backToTheAdd();
                if (tmp != null)
                {
                    ShirtTable.Add(tmp);
                    ClothingTable.Add(tmp);



                    //pb.Image = Image.FromFile(@"C:\Users\mmosh\Desktop\oopprojectfinal\oopprojectfinal\imeges\shirt\shirt.jpg");
                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
                    //pb.Size = new Size(150, 100);//size of the frame 
                    //pb.Location = new Point(500, 50);
                    //this.Controls.Add(pb);//the this is the form
                }
            }
            if (userShoe != null)
            {
                Shoe tmp = userShoe.backToTheAdd();
                if (tmp != null)
                {
                    ShoeTable.Add(tmp);
                    ClothingTable.Add(tmp);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                if (userPants != null)
                {
                    Pants tmp = userPants.backToTheAdd();
                    //we go to the pantsTableLIst ,we know that "selectedRow" has its index of the selected row in the dataGrid. 
                    //so we go the place of the node of the pantsTableLIst and there is a Pants opject inside . we change it to the tmp which is also Pants object 
                    pbLsit.Remove(PantsTable[selectedRow.Index].pb);
                    pbLsit.Add(tmp.pb);
                    PantsTable[selectedRow.Index] = tmp;
                }
                if (userShirt != null)
                {
                    Shirt tmp = userShirt.backToTheAdd();

                    //we go to the ShirtTableLIst ,we know that "selectedRow" has its index of the selected row in the dataGrid. 
                    //so we go the place of the node of the ShirtTableLIst and there is a Shirt opject inside . we change it to the tmp which is also Shirt object 
                    ShirtTable[selectedRow.Index] = tmp;
                }
                if (userShoe != null)
                {
                    Shoe tmp = userShoe.backToTheAdd();

                    //we go to the ShoeTableLIst ,we know that "selectedRow" has its index of the selected row in the dataGrid. 
                    //so we go the place of the node of the ShoeTableLIst and there is a Shoe opject inside . we change it to the tmp which is also Shoe object 
                    ShoeTable[selectedRow.Index] = tmp;
                }

            }
        }



        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = dataGrid.Rows[e.RowIndex];
            fill_info();
            
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (userPants != null)
                userPants.clear();
            if (userShoe != null)
                userShoe.clear();
            if (userShirt != null)
                userShirt.clear();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            if (userPants != null)
            {
                if (selectedRow != null)
                {
                    Pants obj = PantsTable[selectedRow.Index];
                    obj.showPic();

                }
            }
        }



        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                PictureBox clickedPictureBox = (PictureBox)sender;
                int selectedIndex = -1;

                // Find the selected index based on the clicked PictureBox


                for (int i = 0; i < pbLsit.Count; i++)
                {
                    if (pbLsit[i] == clickedPictureBox)
                    {
                        selectedIndex = i;
                        break;
                    }
                }

                if (selectedIndex >= 0 && selectedIndex < pbLsit.Count)
                {
                    // Remove the corresponding row from the DataGridView
                    if (selectedIndex < PantsTable.Count)
                    {
                        PantsTable.RemoveAt(selectedIndex);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = PantsTable;
                    }

                    // Remove the clicked PictureBox from the pictureHolder.Controls
                    pictureHolder.Controls.Remove(clickedPictureBox);
                    pbLsit.Remove(clickedPictureBox);
                }

                return;
            }
            else
            {
                mouseLeft = true;
                foreach (Pants p in PantsTable)
                {
                    if (p.pb == sender)
                    {
                        dataGrid.ClearSelection();
                        dataGrid.DataSource = PantsTable;
                        selectedRow = dataGrid.Rows[PantsTable.IndexOf(p)];
                        selectedRow.Selected = true;

                        fill_info();
                    }
                }
                // Do something for left or middle click
            }

            //isMouseClicked = true;
        }

        //private void pic_MouseDown(object sender, MouseEventArgs e)
        //{
        //    isMouseClicked = true;

        //    foreach (Pants p in PantsTable)
        //    {
        //        if (p.pb == sender)
        //        {
        //            dataGrid.ClearSelection();
        //            dataGrid.DataSource = PantsTable;
        //            selectedRow = dataGrid.Rows[PantsTable.IndexOf(p)];
        //            selectedRow.Selected = true;

        //            fill_info();
        //        }
        //    }
        //}

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseClicked = false;
            mouseLeft = false;
            
            
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (/*isMouseClicked*/mouseLeft)
            {
                if (selectedRow != null)
                {
                    if (pictureHolder.Bounds.Contains(MousePosition))
                    {
                        PictureBox pb = PantsTable[selectedRow.Index].pb;
                        pb.Location = new Point(MousePosition.X - pictureHolder.Location.X - pb.Size.Width / 2, MousePosition.Y - pictureHolder.Location.Y - pb.Size.Height / 2);
                    }
                }
            }
        }

        void fill_info()
        {
            if (userPants != null)
            {

                // Retrieve the values from specific cells in the row

                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string type = selectedRow.Cells["pantsType"].Value.ToString();
                string size = selectedRow.Cells["clothesSize"].Value.ToString();
                string fabric = selectedRow.Cells["fabricType"].Value.ToString();
                string color = selectedRow.Cells["color"].Value.ToString();
                string brand = selectedRow.Cells["brand"].Value.ToString();
                //double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                string price = selectedRow.Cells["price"].Value.ToString();
                userPants.updatePannel(fabric, type, gender, brand, color, price, size);
            }
            if (userShirt != null)
            {
                // Retrieve the values from specific cells in the row

                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string type = selectedRow.Cells["type"].Value.ToString();
                string size = selectedRow.Cells["clothesSize"].Value.ToString();
                string fabric = selectedRow.Cells["fabricType"].Value.ToString();
                string color = selectedRow.Cells["color"].Value.ToString();
                string brand = selectedRow.Cells["brand"].Value.ToString();
                //double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                string price = selectedRow.Cells["price"].Value.ToString();
                userShirt.updatePannel(fabric, type, gender, brand, color, price, size);
            }
            if (userShoe != null)
            {

                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string type = selectedRow.Cells["type"].Value.ToString();
                string size = selectedRow.Cells["shoeSize"].Value.ToString();
                string color = selectedRow.Cells["color"].Value.ToString();
                string brand = selectedRow.Cells["brand"].Value.ToString();
                //double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                string price = selectedRow.Cells["price"].Value.ToString();
                userShoe.updatePannel(type, gender, brand, color, price, size);
            }
        }
        //////////////////////

    }
}

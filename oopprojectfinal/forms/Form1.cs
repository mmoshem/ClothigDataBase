using oopprojectfinal.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        List<PictureBox> pbList = new List<PictureBox>();


        bool mouseLeft = false;


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

                Pants tmp_pants = userPants.backToTheAdd();
                if (tmp_pants != null)
                {
                    PantsTable.Add(tmp_pants);
                    ClothingTable.Add(tmp_pants);

                    tmp_pants.pb.MouseDown += pic_MouseDown;
                    tmp_pants.pb.MouseMove += pic_MouseMove;
                    tmp_pants.pb.MouseUp += pic_MouseUp;

                    pbList.Add(tmp_pants.pb);
                    pictureHolder.Controls.Add(tmp_pants.pb);
                }

            }
            else if (userShirt != null)
            {
                Shirt tmp_shirt = userShirt.backToTheAdd();
                if (tmp_shirt != null)
                {
                    ShirtTable.Add(tmp_shirt);
                    ClothingTable.Add(tmp_shirt);


                    tmp_shirt.pb.MouseDown += pic_MouseDown;
                    tmp_shirt.pb.MouseMove += pic_MouseMove;
                    tmp_shirt.pb.MouseUp += pic_MouseUp;

                    pbList.Add(tmp_shirt.pb);
                    pictureHolder.Controls.Add(tmp_shirt.pb);//the "this" is the form



                }
            }
            else if (userShoe != null)
            {
                Shoe tmp_shoe = userShoe.backToTheAdd();
                if (tmp_shoe != null)
                {
                    ShoeTable.Add(tmp_shoe);
                    ClothingTable.Add(tmp_shoe);

                    tmp_shoe.pb.MouseDown += pic_MouseDown;
                    tmp_shoe.pb.MouseMove += pic_MouseMove;
                    tmp_shoe.pb.MouseUp += pic_MouseUp;

                    pbList.Add(tmp_shoe.pb);
                    pictureHolder.Controls.Add(tmp_shoe.pb);//the "this" is the form
                }

            }
            else
            {
                MessageBox.Show("please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void update_button_Click(object sender, EventArgs e)
        {
            if (selectedRow != null && selectedRow.Index != -1)
            {
                if (userPants != null)
                {

                    Pants tmp = userPants.backToTheAdd();
                    if (tmp != null)
                    {
                        tmp.pb.MouseDown += pic_MouseDown;
                        tmp.pb.MouseMove += pic_MouseMove;
                        tmp.pb.MouseUp += pic_MouseUp;
                        tmp.pb.Location = PantsTable[selectedRow.Index].pb.Location;

                        pbList.Remove(PantsTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Remove(PantsTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Add(tmp.pb);

                        pbList.Add(tmp.pb);

                        ClothingTable.Remove((Clothing)PantsTable[selectedRow.Index]);
                        ClothingTable.Add((Clothing)tmp);


                        PantsTable[selectedRow.Index] = tmp;
                    }

                    //we go to the pantsTableLIst ,we know that "selectedRow" has its index of the selected row in the dataGrid. 
                    //so we go the place of the node of the pantsTableLIst and there is a Pants opject inside . we change it to the tmp which is also Pants object 
                }
                if (userShirt != null)
                {
                    Shirt tmp_shirt = userShirt.backToTheAdd();
                    if (tmp_shirt != null)
                    {
                        tmp_shirt.pb.MouseDown += pic_MouseDown;
                        tmp_shirt.pb.MouseMove += pic_MouseMove;
                        tmp_shirt.pb.MouseUp += pic_MouseUp;
                        tmp_shirt.pb.Location = ShirtTable[selectedRow.Index].pb.Location;

                        pbList.Remove(ShirtTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Remove(ShirtTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Add(tmp_shirt.pb);
                        pbList.Add(tmp_shirt.pb);

                        ClothingTable.Remove((Clothing)ShirtTable[selectedRow.Index]);
                        ClothingTable.Add((Clothing)tmp_shirt);

                        ShirtTable[selectedRow.Index] = tmp_shirt;
                    }
                }
                if (userShoe != null)
                {
                    Shoe tmp_shoe = userShoe.backToTheAdd();
                    if (tmp_shoe != null)
                    {
                        tmp_shoe.pb.MouseDown += pic_MouseDown;
                        tmp_shoe.pb.MouseMove += pic_MouseMove;
                        tmp_shoe.pb.MouseUp += pic_MouseUp;
                        tmp_shoe.pb.Location = ShoeTable[selectedRow.Index].pb.Location;

                        pbList.Remove(ShoeTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Remove(ShoeTable[selectedRow.Index].pb);
                        pictureHolder.Controls.Add(tmp_shoe.pb);
                        pbList.Add(tmp_shoe.pb);

                        ClothingTable.Remove((Clothing)ShoeTable[selectedRow.Index]);
                        ClothingTable.Add((Clothing)tmp_shoe);

                        ShoeTable[selectedRow.Index] = tmp_shoe;
                    }
                }


            }
            else
            {
                MessageBox.Show("To update you must have at least one selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        //blah
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
            if (userShirt != null)
            {
                if (selectedRow != null)
                {
                    Shirt obj = ShirtTable[selectedRow.Index];
                    obj.showPic();

                }
            }
            if (userShoe != null)
            {
                if (selectedRow != null)
                {
                    Shoe obj = ShoeTable[selectedRow.Index];
                    obj.showPic();

                }
            }
        }


        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                PictureBox clickedPictureBox = (PictureBox)sender;
                Clothing tmpClothing = null;
                // Find the selected index based on the clicked PictureBox

                foreach (Clothing i in ClothingTable)
                {
                    if (i.pb == clickedPictureBox)
                    {
                        tmpClothing = i;
                        break;
                    }
                }

                if (tmpClothing != null)
                {
                    if (tmpClothing.item == "Pants")
                    {
                        // Remove the corresponding row from the DataGridView

                        PantsTable.Remove((Pants)tmpClothing);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = PantsTable;


                        // Remove the clicked PictureBox from the pictureHolder.Controls
                        pictureHolder.Controls.Remove(clickedPictureBox);
                        pbList.Remove(clickedPictureBox);
                        ClothingTable.Remove(tmpClothing);
                    }
                    if (tmpClothing.item == "Shirt")
                    {
                        // Remove the corresponding row from the DataGridView

                        ShirtTable.Remove((Shirt)tmpClothing);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = ShirtTable;


                        // Remove the clicked PictureBox from the pictureHolder.Controls
                        pictureHolder.Controls.Remove(clickedPictureBox);
                        pbList.Remove(clickedPictureBox);
                        ClothingTable.Remove(tmpClothing);
                    }
                    if (tmpClothing.item == "Shoe")
                    {
                        // Remove the corresponding row from the DataGridView

                        ShoeTable.Remove((Shoe)tmpClothing);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = ShoeTable;


                        // Remove the clicked PictureBox from the pictureHolder.Controls
                        pictureHolder.Controls.Remove(clickedPictureBox);
                        pbList.Remove(clickedPictureBox);
                        ClothingTable.Remove(tmpClothing);
                    }
                }

                return;
            }
            else if (e.Button == MouseButtons.Left)
            {
                mouseLeft = true;
                foreach (Clothing c in ClothingTable)
                {
                    if (c.pb == sender)
                    {
                        if (c.item == "Pants")
                        {
                            dataGrid.ClearSelection();
                            comboBoxItem.SelectedIndex = 2;
                            if (dataGrid.RowCount != 0)
                            {
                                selectedRow = dataGrid.Rows[PantsTable.IndexOf((Pants)c)];
                                selectedRow.Selected = true;
                                fill_info();
                            }
                        }
                        else if (c.item == "Shirt")
                        {
                            dataGrid.ClearSelection();
                            comboBoxItem.SelectedIndex = 1;

                            if (dataGrid.RowCount != 0)
                            {
                                selectedRow = dataGrid.Rows[ShirtTable.IndexOf((Shirt)c)];
                                selectedRow.Selected = true;
                                fill_info();
                            }
                        }
                        else if (c.item == "Shoe")
                        {
                            dataGrid.ClearSelection();
                            comboBoxItem.SelectedIndex = 0;

                            if (dataGrid.RowCount != 0)
                            {
                                selectedRow = dataGrid.Rows[ShoeTable.IndexOf((Shoe)c)];
                                selectedRow.Selected = true;

                                fill_info();
                            }
                        }
                    }
                }
                // Do something for left or middle click
            }

            //isMouseClicked = true;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {

            mouseLeft = false;


        }


        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseLeft)
            {
                if (selectedRow != null)
                {
                    if (userPants != null)
                    {
                        if (pictureHolder.Bounds.Contains(MousePosition))
                        {
                            PictureBox pb = PantsTable[selectedRow.Index].pb;
                            pb.Location = new Point(MousePosition.X - pictureHolder.Location.X - pb.Size.Width / 2, MousePosition.Y - pictureHolder.Location.Y - pb.Size.Height / 2);
                        }

                    }
                    else if (userShirt != null)
                    {
                        if (pictureHolder.Bounds.Contains(MousePosition))
                        {
                            PictureBox pb = ShirtTable[selectedRow.Index].pb;
                            pb.Location = new Point(MousePosition.X - pictureHolder.Location.X - pb.Size.Width / 2, MousePosition.Y - pictureHolder.Location.Y - pb.Size.Height / 2);
                        }

                    }
                    else if (userShoe != null)
                    {
                        if (pictureHolder.Bounds.Contains(MousePosition))
                        {
                            PictureBox pb = ShoeTable[selectedRow.Index].pb;
                            pb.Location = new Point(MousePosition.X - pictureHolder.Location.X - pb.Size.Width / 2, MousePosition.Y - pictureHolder.Location.Y - pb.Size.Height / 2);
                        }

                    }
                }
            }
        }

        void fill_info()
        {
            if (selectedRow != null && selectedRow.Index!=-1)
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

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int selectedComboItem = -1;
            int selectedRowIndex = -1;

            if (selectedRow != null)
                selectedRowIndex = selectedRow.Index;

            if (userPants != null)
                selectedComboItem = 2;
            if (userShirt != null)
                selectedComboItem = 1;
            if (userShoe != null)
                selectedComboItem = 0;

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("store.oop", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                saver saved = new saver(PantsTable,ShirtTable,ShoeTable,selectedComboItem,selectedRowIndex);
                formatter.Serialize(stream, saved);
            }

            //////////////////////

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            pictureHolder.Controls.Clear();
            ClothingTable = new BindingList<Clothing>();

            if (File.Exists("store.oop"))
            {
                Stream stream = File.Open("store.oop", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                saver loaded = (saver)(binaryFormatter.Deserialize(stream));


                PantsTable = loaded.toBindingListPants();
                ShirtTable = loaded.toBindingListShirts();
                ShoeTable = loaded.toBindingListShoes();
                ClothingTable = loaded.toBindingListClothing();

                foreach (Clothing c in ClothingTable)
                {
                    c.pb.MouseDown += pic_MouseDown;
                    c.pb.MouseMove += pic_MouseMove;
                    c.pb.MouseUp += pic_MouseUp;
                    pictureHolder.Controls.Add(c.pb);
                }


                comboBoxItem.SelectedIndex = loaded.selectedComboBoxItem;
               

                switch (loaded.selectedComboBoxItem)
                {
                    case 0: //shoes
                        comboBoxItem.Refresh();
                        comboBoxItem.SelectedIndex = 0;
                        dataGrid.DataSource = ShoeTable;
                        fill_info();
                        dataGrid.ClearSelection();
                        selectedRow = dataGrid.Rows[loaded.selectedRow];
                        selectedRow.Selected = true;
                        break;
                    case 1: //shirt
                        comboBoxItem.Refresh();
                        comboBoxItem.SelectedIndex = 1;
                        dataGrid.DataSource = ShirtTable;
                        fill_info();
                        dataGrid.ClearSelection();
                        selectedRow = dataGrid.Rows[loaded.selectedRow];
                        selectedRow.Selected = true;
                        break;
                    case 2: //pants
                        comboBoxItem.Refresh();
                        comboBoxItem.SelectedIndex = 2;
                        dataGrid.DataSource = PantsTable;
                        fill_info();
                        dataGrid.ClearSelection();
                        selectedRow = dataGrid.Rows[loaded.selectedRow];
                        selectedRow.Selected = true;
                        break;
                }
                


                stream.Close();
            }
            else
                MessageBox.Show("store file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

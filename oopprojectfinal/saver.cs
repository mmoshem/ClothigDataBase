using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    [Serializable]
    class saver 
    {
        public Pants[] pantsArr;
        public Shirt[] shirtsArr;
        public Shoe[] shoesArr;
        public Clothing[] clothingArr;

        public Point[] points;

        public int selectedComboBoxItem;
        public int selectedRow;

        int _indexToLoad { get; set; }
        public saver(int indexToLoad,BindingList<Pants> pantsList, BindingList<Shirt> shirtsList, BindingList<Shoe> shoesList, int selCombo,int selRow)
        {
            pantsArr = new Pants[pantsList.Count];
            shirtsArr = new Shirt[shirtsList.Count];
            shoesArr = new Shoe[shoesList.Count];
            clothingArr = new Clothing[pantsList.Count + shirtsList.Count + shoesList.Count];
            
            points = new Point[clothingArr.Length];
            
            int j = 0;

            for (int i = 0; i < pantsList.Count; i++)
            {
                pantsArr[i] = pantsList[i];
                clothingArr[j] = pantsArr[i];
                j++;
            }

            for (int i = 0; i < shirtsList.Count; i++)
            {
                shirtsArr[i] = shirtsList[i];
                clothingArr[j] = shirtsList[i];
                j++;
            }

            for (int i = 0; i < shoesList.Count; i++)
            {
                shoesArr[i] = shoesList[i];
                clothingArr[j] = shoesList[i];
                j++;
            }

            for (int i = 0; i < clothingArr.Length; i++)
            {
                points[i] = clothingArr[i].pb.Location;
            }
            _indexToLoad = indexToLoad;
            selectedComboBoxItem = selCombo;
            selectedRow = selRow;
        }
        public int getTheIndex()
        {
            return _indexToLoad;
        }

        public BindingList<Pants> toBindingListPants()
        {
            BindingList<Pants> bl = new BindingList<Pants>();

            foreach (Pants p in pantsArr)
            {
                bl.Add(p);
            }
            return bl;
        }

        public BindingList<Shirt> toBindingListShirts()
        {
            BindingList<Shirt> bl = new BindingList<Shirt>();

            foreach (Shirt s in shirtsArr)
            {
                bl.Add(s);
            }
            
            return bl;
        }

        public BindingList<Shoe> toBindingListShoes()
        {
            BindingList<Shoe> bl = new BindingList<Shoe>();

            foreach (Shoe s in shoesArr)
            {
                bl.Add(s);
            }
            return bl;
        }

        public BindingList<Clothing> toBindingListClothing()
        {
            BindingList<Clothing> bl = new BindingList<Clothing>();

            for (int i = 0; i < clothingArr.Length; i++)
            {
                bl.Add(clothingArr[i]);
                clothingArr[i].loadPic();
                clothingArr[i].pb.Location = points[i];

            }
            return bl;
        }

       

    }
}

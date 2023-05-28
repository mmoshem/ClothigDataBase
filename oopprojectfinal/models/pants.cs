using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace oopprojectfinal
{
    [Serializable]

    public class Pants : Clothes
    {
        public string pantsType { get; set; }


        public override void loadPic()
        {
            pb = new PictureBox();

            string imagePath = Application.StartupPath;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath += @"\pants\" + color + ".jpg";


            pb.Image = Image.FromFile(imagePath);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
            pb.Size = new Size(50, 50);//size of the frame 

        }



        public Pants(string item, string gender,  string color, string brand, double price, string fubricType,string clothesSize , string pantsType) : base( item, gender,color, brand, price, fubricType, clothesSize)
        {
            this.pantsType = pantsType;

            loadPic();
            
        }
        
    }
}

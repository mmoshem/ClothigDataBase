using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    [Serializable]
    public class Shirt : Clothes
    {
       public string type { get; set; }


        public override void loadPic()
        {
            pb = new PictureBox();

            string imagePath = Application.StartupPath;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath += @"\shirt\" + color + ".jpg";


            pb.Image = Image.FromFile(imagePath);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
            pb.Size = new Size(50, 50);//size of the frame 
        }

        public Shirt(string item,string gender , string color, string brand, double price, string fubricType, string clothesSize, string type) : base(item,gender, color, brand, price, fubricType, clothesSize)
        {
            this.type = type;

            loadPic();
        }
        


    }
}

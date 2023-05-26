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
    public class Shoe:Clothing
    {
        
      public string type { get; set; }

      public double shoeSize { get; set; }


        public override void loadPic()
        {
            string imagePath = Application.StartupPath;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath += @"\shoe\" + color + ".jpg";


            pb.Image = Image.FromFile(imagePath);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
            pb.Size = new Size(50, 50);//size of the frame 
        }

        public Shoe(string item,string gender, string color, string brand, double price,double shoeSize, string type): base(item, gender, color, brand,price)
        {
            this.type = type;   
            this.shoeSize = shoeSize;

            loadPic();
        }


    }
    
}

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
    public class Pants : Clothes
    {
        public string pantsType { get; set; }

        public override void showPic()
        {
            /*
            using (Form form = new Form())
            {
                string relativePath = @"images/pants/first"; // Provide the correct relative path to the image file

                string imagePath = System.IO.Path.Combine(Application.StartupPath, relativePath);
                //@"C:\Users\mmosh\Desktop\oopprojectfinal\oopprojectfinal\imeges\pants\365132_308_XL.jpg"


                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(imagePath);
                pb.Width = 1000;
                pb.Height = 1000;
                form.StartPosition = FormStartPosition.WindowsDefaultBounds;
                form.Size = pb.Size;
                
                form.Controls.Add(pb);
                form.ShowDialog();
            }
            //throw new NotImplementedException();
            */
        }
        public Pants(string item, string gender,  string color, string brand, double price, string fubricType,string clothesSize , string pantsType) : base( item, gender,color, brand, price, fubricType, clothesSize)
        {
            this.pantsType = pantsType;

            string imagePath = Application.StartupPath;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath += @"\images\pants\first.jpg";


            pb.Image = Image.FromFile(imagePath);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
            pb.Size = new Size(100, 100);//size of the frame 
        }
        
    }
}

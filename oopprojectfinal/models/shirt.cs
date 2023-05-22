using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    public class Shirt : Clothes
    {
       public string type { get; set; }

  
        public Shirt(string item,string gender , string color, string brand, double price, string fubricType, string clothesSize, string type) : base(item,gender, color, brand, price, fubricType, clothesSize)
        {
            this.type = type;
        }
        public override void showPic()
        {
            using (Form form = new Form())
            {
                //string relativePath = @"Images\Pants\sp-pgm-dc-11.jpg"; // Provide the correct relative path to the image file

                //string imagePath = System.IO.Path.Combine(Application.StartupPath, relativePath);



                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(@"C:\Users\mmosh\Desktop\oopprojectfinal\oopprojectfinal\imeges\shirts\images.jpeg");
                pb.Width = 1000;
                pb.Height = 1000;
                form.StartPosition = FormStartPosition.WindowsDefaultBounds;
                form.Size = pb.Image.Size;
                form.Controls.Add(pb);
                form.ShowDialog();
            }
            //throw new NotImplementedException();
        }

    }
}

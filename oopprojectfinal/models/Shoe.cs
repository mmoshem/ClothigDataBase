using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    public class Shoe:Clothing
    {
        
      public string type { get; set; }

      public double shoeSize { get; set; }

        public override void showPic()
        {
            using (Form form = new Form())
            {
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(@"C:\Users\mmosh\Desktop\oopprojectfinal\oopprojectfinal\imeges\shoes\download.jpeg");
                pb.Width = 1000;
                pb.Height = 1000;
                form.StartPosition = FormStartPosition.WindowsDefaultBounds;
                form.Size = pb.Image.Size;
                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }

        public Shoe(string item,string gender, string color, string brand, double price,double shoeSize, string type): base(item, gender, color, brand,price)
        {
            this.type = type;   
            this.shoeSize = shoeSize;
        }
    }
    
}

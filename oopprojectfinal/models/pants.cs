using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace oopprojectfinal
{
    public class Pants : Clothes
    {
        public string pantsType { get; set; }

        public override void showPic()
        {

            using (Form form = new Form())
            {
                PictureBox pbCopy = new PictureBox();

                pbCopy.Image = (Image)(pb.Image.Clone());

                pbCopy.SizeMode = PictureBoxSizeMode.StretchImage;
                pbCopy.Size = form.Size;

                form.Controls.Add(pbCopy);
                form.ShowDialog();
            }
            //throw new NotImplementedException();

        }

 

        public Pants(string item, string gender,  string color, string brand, double price, string fubricType,string clothesSize , string pantsType) : base( item, gender,color, brand, price, fubricType, clothesSize)
        {
            this.pantsType = pantsType;

            string imagePath = Application.StartupPath;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath = Directory.GetParent(imagePath).FullName;
            imagePath += @"\pants\"+color+".jpg";


            pb.Image = Image.FromFile(imagePath);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//makes the pic in the size of the image
            pb.Size = new Size(50, 50);//size of the frame 
        }
        
    }
}

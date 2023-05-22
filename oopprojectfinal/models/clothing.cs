using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopprojectfinal
{
    public abstract class Clothing
    {
        public string gender { get; set; }
        public string color { get; set; }   
        public string brand { get; set; } 
        public double price { get; set; }
        public string item { get; set; }

        public abstract void showPic();
        public Clothing(string item, string gender, string color,string brand, double price )
        { 
            this.gender = gender;
            this.color = color; 
            this.brand = brand;
            this.item = item;
            this.price = price;
        }
       
    }
}

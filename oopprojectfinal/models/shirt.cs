using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectfinal
{
    public class Shirt : Clothes
    {
       public string type { get; set; }
       

        public Shirt(string item,string gender , string color, string brand, double price, string style, string fubricType, string clothesSize, string type) : base(item,gender, color, brand, price, fubricType, clothesSize)
        {
            this.type = type;
        }

    }
}

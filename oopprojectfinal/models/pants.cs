using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectfinal
{
    public class Pants : Clothes
    {
        public string pantsType { get; set; }
  
        public Pants(string item, string gender,  string color, string brand, double price, string fubricType,string clothesSize , string pantsType) : base( item, gender,color, brand, price, fubricType, clothesSize)
        {
            this.pantsType = pantsType;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectfinal
{
    public abstract class Clothes:Clothing
    {
       
        public string fubricType { get; set; }
        public string clothesSize { get; set; }


        protected Clothes(string item, string gender, string color, string brand, double price, string fubricType, string clothesSize) : base(item, gender, color, brand, price)
        {
            this.fubricType = fubricType;
            this.clothesSize = clothesSize;
        }

      

     
    }

}

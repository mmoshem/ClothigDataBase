using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectfinal
{
    public class Shoe:Clothing
    {
        
        public string type { get; set; }

      public int shoeSize { get; set; }
        
        public Shoe(string item,string gender, string color, string brand, double price, string type): base(item, gender, color, brand,price)
        {
            this.type = type;   
            this.shoeSize = shoeSize;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectfinal
{
    [Serializable]
    class saver<T> //T is templates
    {
        public T[] array;


        public saver(BindingList<T> list)
        {
            array = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
        }
    }
}

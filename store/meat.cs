using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class meat <T> :products
    {
        public List<T> AnList { get; set; }

        public meat(string producName, int producPrice, List<T> anList): 
            base(producName,producPrice)
        {
            AnList = anList;
        }

        public int PriceMeat()
        {

            return producPrice;
        }

        public string ProducName()
        {
            return $"El nombre de su producto es: {producName}";
        }

        public void add(T v)
        {

            AnList.Add(v);
           
        }
    }
}

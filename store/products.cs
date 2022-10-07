using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class products
    {

        public string producName { get; }
        public int producPrice { get; }
        
     

        public products(string producName, int producPrice)
        {
            this.producName = producName;
            this.producPrice = producPrice;
        }
    }
}

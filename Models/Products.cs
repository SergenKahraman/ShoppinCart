using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Products
    {
        public string productName;
        public double productPrice;
        public int AmountInCart = 0;
        

        public override string ToString()
        {
            return productName;
        }
        public double CalculateTotalPrice()
        {
            return AmountInCart * productPrice;
        }

    }
}

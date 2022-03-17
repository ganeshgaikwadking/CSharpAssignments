using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    class Product
    {
        int productcode;
        string productname;
        double price, discount,finalprice;


        public Product()
        {
            productcode = 101;
            productname = "oppo";
            price = 10000;
            finalprice = 10000;
            discount = 0.0;

        }
        public Product(int pcode, string pname, double pric,double dics)
        {
           productcode = pcode;
           productname = pname;
           price = pric;
           discount = dics;


        }
        public  void Discount()
        {
            if(price > 5000)
            {
                discount = price * 0.1;
                finalprice = price - discount;
            }
            else
            {
                Console.WriteLine($"price {price}");
            }
           

        }
        public override string ToString()
        {
            return " Product Code = " + productcode+"::" + "product Name =" + productname+"::" + "Price " + price+"::" + " Final Price " + finalprice;
        }

    }

}

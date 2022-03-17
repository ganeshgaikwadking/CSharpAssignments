using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    public class ProductAi
    {

        static int count;
        protected int id;
       protected string name;

        public ProductAi()
        {
            count++;
            id = 11;
            name = "mobile";

            count++;
            id = 12;
            name = "Laptop";

            count++;
            id = 13;
            name = "Tv";

            count++;
            id = 14;
            name = "Pc";

        }
        public ProductAi(int Coun,int idd,string nm)
        {
            count = Coun;
            id = idd;
            name = nm;

        }
        public static int Getcount()
        {
            return count;
        }
        public override string ToString()
        {
            return "Count=" + count+  ":: " + " id= " + id +":: " + " Name= " + name;
        }



    }
}

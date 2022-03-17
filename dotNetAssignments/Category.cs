using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    class Category
    {
        int id;
        string category;

        public Category()
        {
            id = 1;
            category = "android";
        }
        public Category(int idd,string cate )
        {
            id = idd;
            category= cate;
        }
        public override string ToString()
        {
            return "Id = " + id + "::" + "category = " + category;
        }
    }
}

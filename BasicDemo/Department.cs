using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class Department
    {
        private int id;
        private string name, location;
        //public void AssignData()
        //{
        //    id = 1;
        //    name = "Admin";
        //    location = "Pune";

        //}
        public Department()
        {
            id = 1;
            name = "Admin";
            location = "Pune";
        }
        public Department(int did,string dname,string loc)
        {
            id = did;
            name = dname;
            location = loc;
        }
        public int GetDataId()
        {

            return id;
        }
        public string GetData()
        {

            return " Dept Id = " + id + " Dept Name = " + name + " location = " + location;
        }

    }
}

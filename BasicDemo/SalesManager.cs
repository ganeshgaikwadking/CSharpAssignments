using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
   public  class SalesManager:Employee
    {
        private double foodallow, ta, comission;

        public SalesManager() : base()
        {
            foodallow = 0.0;
            ta = 0.0;
            comission = 0.0;
        }
        public SalesManager(int id, string nm, double bs, double foodallow, double ta, double com):base(id,nm,bs)
        {

            this.foodallow = foodallow;
            this.ta = ta;
            this.comission = com;
        }
        public override void calculatesalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.01;
            grosssalary = (basicsalary + hra + da+foodallow+ta+comission) - pf;
        }
        public override string ToString()
        {
            return " EmpId " + empid + " EmpName " + empname + " Gross salary " + grosssalary;
        }
    }
}

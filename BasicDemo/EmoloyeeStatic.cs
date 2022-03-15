using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class EmoloyeeStatic
    {
        
         static int count;
        protected int empid;
        protected string empname;
        protected double basicsalary, hra, da, pf, grosssalary;



        public EmoloyeeStatic()
        {
            count++;
            empid = count;
            empname = "";
            basicsalary = 0.0;

        }
        public EmoloyeeStatic( string empname, double basicsalary)
        {
            count ++;
            empid= count;
            this.empname = empname;
            this.basicsalary = basicsalary;

        }
        public virtual void calculatesalary()
        {

            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.01;
            grosssalary = (basicsalary + hra + da) - pf;

        }
        public static int GetCount()
        {
            return count;
        }
        public override string ToString()
        {
            return " EmpId " + empid + " EmpName " + empname + " Gross salary " + grosssalary;
        }
    }
}


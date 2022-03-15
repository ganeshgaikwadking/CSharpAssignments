using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    public class Employee
    {
        protected int empid;
        protected string empname;
        protected double basicsalary,hra,da,pf,grosssalary;



        public Employee()
        {
            empid = 0;
            empname = "";
            basicsalary = 0.0;

        }
        public Employee(int empid, string empname, double basicsalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.basicsalary = basicsalary;

        }
        public virtual  void calculatesalary()
        {

            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.01;
            grosssalary = (basicsalary + hra + da) - pf;

        }
        public override string ToString()
        {
            return " EmpId " + empid + " EmpName " + empname + " Gross salary "+ grosssalary;
        }
    }
  }

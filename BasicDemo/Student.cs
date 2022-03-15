using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    public class Student
    {
        int RollNo;
        string Name, Div;
        public Student()
        {
            RollNo = 1;
            Name = "Ganesh";
            Div = "A";

        }
        public Student(int sRollno,string sname,string sdiv)
        {
            RollNo = sRollno;
            Name = sname;
            Div = sdiv;
                
        }
        public string GetData()
        {

            return "Sudent RollNo = " + RollNo + " Name = " + Name + " Div = " + Div;
        }

    }
}

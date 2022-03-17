using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    class Studentcl
    {
        int RollNo;
        string Name;
        double percentage;
        string res;

        public Studentcl()
        {
            RollNo = 1;
            Name = "Bhushan";
            percentage = 40;
            res = "";

            

        }
        public Studentcl(int rno,string nm,double per,string rs)
        {
            RollNo = rno;
            Name = nm;
            percentage = per;
            res = rs;


        }
        public void Result()
        { 
        
        if(percentage <= 40)
            {

                Console.WriteLine("Fail");
            }
        else
            {
                Console.WriteLine("Pass");
            }
        }
        public override string ToString()
        {
            return " RollNo = " + RollNo+"::" + " Name =" + Name + "::"+ "Percentage= " + percentage+ "::" + "Result = " +res;
        }
    }

}

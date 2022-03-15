using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Console.WriteLine(department.GetData());
            //string str = department.GetData();
            //Console.WriteLine(str);
            Department dept = new Department(2, "HR", "Mumbai");
            Console.WriteLine(dept.GetData());
            Department dept2 = new Department(3, "Account", "Nashik");
            Console.WriteLine(dept2.GetData());

            Console.WriteLine("==================================================");

            Student st = new Student();
            Console.WriteLine(st.GetData());

            Student st1 = new Student(2, "Tush", "B");
            Console.WriteLine(st1.GetData());

            Console.WriteLine("==================================================");


            Employee emp1 = new Employee(1,"Vishal",30000);
            emp1.calculatesalary();
            Console.WriteLine(emp1.ToString());

            Console.WriteLine("=================sales manager=================================");


            SalesManager sm = new SalesManager(10, "Rutik", 30000, 1000, 1500, 500);
            sm.calculatesalary();
            Console.WriteLine(sm);
             
        }
    }
}

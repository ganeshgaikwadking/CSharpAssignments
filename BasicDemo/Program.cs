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

            int[] rainfall = new int[5] { 115, 113, 111, 114, 112 };
            int[] list1 = new int[3];
            string[] names = { "Tushar", "Rahul", "Ganesh", "Sameer" };

            Console.WriteLine("=============Printing Array============");

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);

            }

            Array.Copy(rainfall, 1, list1, 0, 3);

            Console.WriteLine("=============Copied Data============");
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }

            Array.Sort(rainfall);
            Console.WriteLine("==============After Sort============");

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }

            Console.WriteLine("==============Clear Array ============");

            Array.Clear(rainfall, 0, rainfall.Length);
 

            foreach (int val in rainfall)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("=========Printing String Array ==========");
            names.ToList().ForEach(i => Console.WriteLine(i.ToString()));


            Console.WriteLine("=========String Reverse ==========");

            Array.Reverse(names);

            // Displays the values of the Array.
            Console.WriteLine("After reversing:");
            PrintIndexAndValues(names);
        }

        private static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));


            //Department department = new Department();
            //Console.WriteLine(department.GetData());
            ////string str = department.GetData();
            ////Console.WriteLine(str);
            //Department dept = new Department(2, "HR", "Mumbai");
            //Console.WriteLine(dept.GetData());
            //Department dept2 = new Department(3, "Account", "Nashik");
            //Console.WriteLine(dept2.GetData());

            //Console.WriteLine("==================================================");

            //Student st = new Student();
            //Console.WriteLine(st.GetData());

            //Student st1 = new Student(2, "Tush", "B");
            //Console.WriteLine(st1.GetData());

            //Console.WriteLine("==================================================");


            //Employee emp1 = new Employee(1,"Vishal",30000);
            //emp1.calculatesalary();
            //Console.WriteLine(emp1.ToString());

            //Console.WriteLine("=================sales manager=================================");


            //SalesManager sm = new SalesManager(10, "Rutik", 30000, 1000, 1500, 500);
            //sm.calculatesalary();
            //Console.WriteLine(sm);


            //Console.WriteLine("=================Class calculation=================================");
            //Calculation c = new Calculation();
            //Console.WriteLine(c.Addition(10, 20,30));

            //Console.WriteLine("=================Employee Static=================================");

            //EmoloyeeStatic es = new EmoloyeeStatic("Ganesh",20000);
            //es.calculatesalary();
            //Console.WriteLine(es);

            //EmoloyeeStatic es1 = new EmoloyeeStatic("Raj",25000);
            //es1.calculatesalary();
            //Console.WriteLine(es1);

            //EmoloyeeStatic es2 = new EmoloyeeStatic("Shekhar",30000);
            //es2.calculatesalary();
            //Console.WriteLine(es2);

            //Console.WriteLine("Total Employees =" + EmoloyeeStatic.GetCount());
        }
    }
}


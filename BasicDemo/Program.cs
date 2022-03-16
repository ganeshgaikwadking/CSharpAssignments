using System;
using System.Collections;
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

            List<ProductNew> productlist = new List<ProductNew>()
            {

                new ProductNew(101,"Laptop",50000),
                new ProductNew(102,"Mobile",25000),
                new ProductNew(103,"tv",30000),


            };
            foreach (ProductNew p in productlist)
            {
                Console.WriteLine(p);
            }










            //Console.WriteLine("==========Stack===========");
            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(60);
            //stack.Push(30);
            //stack.Push("Ganesh");
            //stack.Push(1.55);

            //stack.Pop();
            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("==========Queue===========");

            //Queue queue = new Queue();
            //queue.Enqueue(101);
            //queue.Enqueue(105);
            //queue.Enqueue(107);
            //queue.Enqueue("Raj");
            //queue.Enqueue(109);
            //queue.Enqueue("Viraj");
            //queue.Enqueue(110);

            //queue.Dequeue();
            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();

            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            //list.Add(50);
            //list.Add("ganesh");
            //list.Add("Test");

            //list.Insert(2, 5);



            //list.Remove(40);
            //list.RemoveAt(3);
            //Console.WriteLine("Count " + list.Count);

            //foreach(object item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] list = new int[6, 3]
            //{
            //    { 101,102,103},
            //    { 101,102,103},
            //    { 101,102,103},
            //    { 101,102,103},
            //    { 101,102,103},
            //    { 101,102,103}

            //};
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(list[i, j] + " ");

            //    }
            //    Console.WriteLine();

            //}

            //Product pd = new Product(10, "Vivo", 56000, 10);
            //pd.Discount();
            //Console.WriteLine(pd.ToString());

            //Product pd1 = new Product();

            //Console.WriteLine(pd1.ToString());


            //    int[] rainfall = new int[5] { 115, 113, 111, 114, 112 };
            //    int[] list1 = new int[3];
            //    string[] names = { "Tushar", "Rahul", "Ganesh", "Sameer" };

            //    Console.WriteLine("=============Printing Array============");

            //    for (int i = 0; i < rainfall.Length; i++)
            //    {
            //        Console.WriteLine(rainfall[i]);

            //    }

            //    Array.Copy(rainfall, 1, list1, 0, 3);

            //    Console.WriteLine("=============Copied Data============");
            //    for (int i = 0; i < rainfall.Length; i++)
            //    {
            //        Console.WriteLine(rainfall[i]);
            //    }

            //    Array.Sort(rainfall);
            //    Console.WriteLine("==============After Sort============");

            //    for (int i = 0; i < rainfall.Length; i++)
            //    {
            //        Console.WriteLine(rainfall[i]);
            //    }

            //    Console.WriteLine("==============Clear Array ============");

            //    Array.Clear(rainfall, 0, rainfall.Length);


            //    foreach (int val in rainfall)
            //    {
            //        Console.WriteLine(val);
            //    }

            //    Console.WriteLine("=========Printing String Array ==========");
            //    names.ToList().ForEach(i => Console.WriteLine(i.ToString()));


            //    Console.WriteLine("=========String Reverse ==========");

            //    Array.Reverse(names);

            //    // Displays the values of the Array.
            //    Console.WriteLine("After reversing:");
            //    PrintIndexAndValues(names);
            //}

            //private static void PrintIndexAndValues(Array myArray)
            //{
            //    for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            //        Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));


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


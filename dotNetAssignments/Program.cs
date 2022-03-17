using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Customer Assignment=============");
            Product pd = new Product(10, "Vivo", 56000, 10);
            pd.Discount();
            Console.WriteLine(pd.ToString());

            Product pd1 = new Product();
            Console.WriteLine(pd1.ToString());

            Console.WriteLine("==========Student Assignment=============");

            Studentcl st = new Studentcl();
            st.Result();
            Console.WriteLine(st.ToString());

            Studentcl st1 = new Studentcl(2, "Baji", 50 ," ");
            st1.Result();
            Console.WriteLine(st1.ToString());

            Studentcl st2 = new Studentcl(4,"Sujay",40," ");
            st2.Result();
            Console.WriteLine(st2.ToString());

            Console.WriteLine("==========Food Assignment=============");

            Dictionary<string, double> dictonary = new Dictionary<string, double>();
            Food fd1 = new Food("PavBhaji", 150);
            Console.WriteLine(fd1.ToString());
            Food fd2 = new Food("Pulav", 100);
            Console.WriteLine(fd2.ToString());
            Food fd3 = new Food("Panner", 150);
            Console.WriteLine(fd3.ToString());
            Food fd4= new Food("PAnnerTikka", 150);
            Console.WriteLine(fd4.ToString());
            Food fd5 = new Food("Roti", 150);
            Console.WriteLine(fd5.ToString());

            foreach (KeyValuePair<string, Double> item in dictonary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("==========Category Assignment List=============");

            List<Category> productlist = new List<Category>()
            {

                new Category(101,"Ios"),
                new Category(102,"Android"),
                new Category(103,"Android"),
                new Category(105,"IOS"),
                new Category(108,"Android"),

            };
            foreach (Category p in productlist)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("==========Array Assignment=============");

         
            string[] Employees = { "Tushar", "Rahul", "Ganesh", "Sameer" };

            Console.WriteLine("=============Printing Employee Array============");

            foreach (string val in Employees)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("==========Product with AutoIncreament Assignment=============");

            ProductAi pa = new ProductAi();
            pa.Id = 1;
            pa.Name = "Mobile";
            Console.WriteLine(pa.Id + pa.Name);

        }
    }
}

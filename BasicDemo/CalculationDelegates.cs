using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    public delegate int MyDelegate(int n1, int n2);
    public delegate string MyStrDel(string name);
   public  class CalculationDelegates
    {
        public int Addition(int a,int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }


    }
    public class Test
    { 
    public string AcceptName(string name)
        {
            return name.ToUpper();

        }
    
    }
}

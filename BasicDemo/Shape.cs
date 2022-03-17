using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
   abstract public  class Shape
    {

        abstract public void CalculateArea(); 
    }
    public class Rectangle :Shape
    {
        private int lenght;
        private int breadth;
        private int result;
        
        public Rectangle(int len,int br)
        {

            this.lenght = len;
            this.lenght = br;
        }

        public override void CalculateArea()
        {
            result = lenght * breadth;
        }
        public override string ToString()
        {
            return "Area Of Reactangle :" + result;
        }
    }
}

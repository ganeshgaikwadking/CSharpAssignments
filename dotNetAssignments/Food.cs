using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
  public  class Food
    {
        string FoodName;
        int Price;
        public Food()
        {
            FoodName = "";
            Price = 0;

        }
        public Food(string Foodnm,int Pric)

        {
            FoodName = Foodnm;
            Price = Pric;
      
        }
        public override string ToString()
        {
            return " Food Name = " + FoodName + "::"+"Price =" + Price;
        }
    }

}

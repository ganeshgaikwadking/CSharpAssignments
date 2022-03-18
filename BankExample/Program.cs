using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    public delegate void Displaymsg1();
     class Program
    {
        public void Deposite()
        {
            Console.WriteLine("deposited Amount...");
        }
        static void LowBalane()
        {
            Console.WriteLine("Balance Is Low");
        }
        static void ZeroBal()
        {
            Console.WriteLine("Your Balance Is Zero....");
        }
        static void InsufficientBalance()
        {
            Console.WriteLine("Yuor Balance Is Insufficient....");
        }
       

        static void Main(string[] args)
        {
            Bankcl bank = new Bankcl();
            bank.LowBalace +=new  Displaymsg1(LowBalane);
            bank.ZeroBal += new Displaymsg1(ZeroBal);
            bank.InsufficeintBal+=new Displaymsg1(InsufficientBalance);
            
            double bal = bank.Withdraw(12000);
            Console.WriteLine("your Balance Is " + bal);
        }
    }
}

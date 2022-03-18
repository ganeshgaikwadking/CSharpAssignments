using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    public class Bankcl
    {
        public event Displaymsg1 LowBalace;
        public event Displaymsg1 deposite;
        public event Displaymsg1 ZeroBal;
        public event Displaymsg1 InsufficeintBal;
        double bal;

        public Bankcl()
        {
            bal = 10000;

        }
        public double Deposit(double Amount)
        {
            bal += Amount;
            return bal;
        }
        public double Withdraw(double Amount)
        {

            double available = bal - Amount;
            if(available<0)
            {
                InsufficeintBal();
                return bal;
            }
            else
            {
                bal -= Amount;
                if(bal==0)
                {
                    ZeroBal();
                    return bal;

                }
                else if(bal<3000)
                {
                    LowBalace();
                    return bal;
                }
                else
                {
                    return bal;
                }
            }
        }

    }
    
}

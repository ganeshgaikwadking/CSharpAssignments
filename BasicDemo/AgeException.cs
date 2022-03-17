using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
   public  class AgeException:Exception

    {
        public AgeException(string msg):base(msg)
        {

        }

    }
    public class user
    {
        public int AcceptAge(int age)
        {
            if(age < 18)
            {
                throw new AgeException("This User Not Valid For Vote");
            }
            return age;
        }

    }
}

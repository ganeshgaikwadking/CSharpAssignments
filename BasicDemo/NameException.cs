using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
   public class NameException:Exception
    {
        
        public NameException(String msg):base (msg)
        {

        }

    }
    public class Voter
    {
        public String AcceptName(string name)
        {

            if(string.IsNullOrEmpty(name))
            {
                throw new NameException("Null or Empty Name Not Allow");
            }
            return name;
            
        }
    }
}

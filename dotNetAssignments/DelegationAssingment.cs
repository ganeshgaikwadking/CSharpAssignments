using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
   
        public delegate string StrDel(string name);
        public class DelegationAssingment
        {
            public string AcceptString1(string name)
        {
            return name.ToUpper();

        }
        public string AcceptString2(string name)
        {

            return name.ToLower();
        }

        internal Delegate[] GetInvovationList()
        {
            throw new NotImplementedException();
        }
    }
}

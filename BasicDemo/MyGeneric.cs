using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
   public class MyGeneric<T>
    {
        private T data;
        public MyGeneric(T data)
        {
            this.data = data;

        }
        public T GetData()
        {
            return data;

        }

    }
}

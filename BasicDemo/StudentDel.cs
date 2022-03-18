using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
  public   class StudentDel
    {
        public event DisplayMsg FailEvent;
        public event DisplayMsg PassEvent;

        public void AcceptMarks(int marks)
        {
            if (marks >= 40)
            {
                PassEvent();
            }
            else
            {
                FailEvent();
            }
        }

    }
}

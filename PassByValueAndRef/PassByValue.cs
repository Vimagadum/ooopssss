using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PassByValue
{
    class PassByValue
    {
        public void PassValue(int a)
        {
            a = 200;
            Console.WriteLine(a);
        }
    }
}

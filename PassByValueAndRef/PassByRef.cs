using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PassByValueAndRef
{
    internal class PassByRef
    {
        public void PassRef(ref int a)
        {
            a = 200;
            Console.WriteLine(a);
        }
    }
}

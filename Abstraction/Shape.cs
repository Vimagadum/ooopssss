using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    abstract class Shape
    {
        public abstract void DrawShape();

        public void ReadMethod()
        {
            Console.WriteLine("Implement my abstract methos");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    internal class Circle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Circle is drawn");
        }
    }
}

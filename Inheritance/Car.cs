using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance
{

    class Car : Vehicle
    {
        public string CarName;
        public int CarNumber;
        public void stop()
        {
            Console.WriteLine(" car is stoped");
        }

    }
}
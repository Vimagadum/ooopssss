using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism.Method_Overriding
{
    class Students : Collage
    {
        public String StudentName = "Jackson";
        public long StudentPhoneNumber = 8112344551;
        string StudentBloodGroup = "A+";
        int StudentMarks = 90;

        public void Details()
        {
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentPhoneNumber);
            Console.WriteLine(StudentBloodGroup);
            Console.WriteLine(StudentName + " " + "got marks" + StudentMarks);

        }

        public new void CollageLocation()
        {
            Console.WriteLine("Collage Location is Belgaum Karnataka");
        }

    }
}
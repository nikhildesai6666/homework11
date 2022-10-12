using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    internal class Class1
    {
        static void Main(string[]args)
        {
            Student s1 = new Student( "Nikhil", 50, 65, 75);
            s1.calculate();
            Console.WriteLine(s1);

            Student s2 = new Student("Akash", 65, 78, 45);
            s2.calculate();
            Console.WriteLine(s2);

            Student s3 = new Student("Pranav",56,97,79);
            s3.calculate();
            Console.WriteLine(s3);
            

        }
    }
}

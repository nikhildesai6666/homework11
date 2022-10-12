using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework11
{
    public class Student
    {
        private int rollno;
        private string name;
        private static int count;
        private double sub1, sub2, sub3, total, per;

        public Student(string name, double sub1, double sub2, double sub3)
        {
            count++;
            this.rollno = count;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }
        public void calculate()
        {
            total = sub1 + sub2 + sub3;
            per = total / 3;
        }
        public override string ToString()
        {
            return $"Roll No {rollno} Name {name} Total {total} Percentage {per}";

        }
    }
    

}

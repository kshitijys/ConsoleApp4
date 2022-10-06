using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    public class Student
    {

        private int rollno, phy, chem, maths, total;
        private string name;
        private double percentage;
        public Student(int rollno, int phy, int chem, int maths, string name)
        {
            this.rollno = rollno;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;

            this.name = name;

        }

        public void calculation()
        {
            total = phy + chem + maths;
            percentage = total / 3;
        }
        public override string ToString()

        {
            return $"rollno={rollno} name={name} total={total} percentage={percentage}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Course
    {
        private int id;
        private string name;
        private float fees;

        public Course(int id, string name, float fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }

        public override string ToString()
        {
            return $" Course Id {id} name {name} Fees {fees}";
        }

    }
}

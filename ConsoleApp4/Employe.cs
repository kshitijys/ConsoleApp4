using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     public class Employe
    {
        private int Id;
        private string Name;
        private float Salary;

      public Employe(int id, string name, float salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
      public override string ToString()
        {
            return $"id={Id} name={Name} salary={Salary}";

        }
    }
}

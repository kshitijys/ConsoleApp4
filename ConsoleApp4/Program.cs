using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student(101,81,85,90,"ram");
            //s1.calculation();
            //Console.WriteLine(s1);


            // employee

            //Employe E1 = new Employe(101, "ram", 30000);
            //Console.WriteLine(E1);


            //course

            //Course c1 = new Course(111, "java", 25000);
            //Console.WriteLine( c1);


            //department  using property

            Department d1=new Department();
            d1.Deptid = 101;
            d1.Deptname="finance";
            d1.Locationp = "pune";

            Console.WriteLine($"{d1.Deptid},{d1.Deptname},{d1.Locationp}");


            Department d2 = new Department { Deptid = 102, Deptname = "technical", Locationp = "mumbai" };
            Console.WriteLine(d2);
        }
    }
}

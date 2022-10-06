using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Department
    {
        private int deptid;
        private string deptname;
        private string locationp;
        public int Deptid
        {
            get { return deptid; }
            set { deptid = value; }
        }
        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }

        public string Locationp
        {
            get { return locationp; }
            set { locationp = value; }
        }

        public override string ToString()
        {
            return $"deptid={deptid},deptname={deptname},lacation={locationp}";


        }
    }
}

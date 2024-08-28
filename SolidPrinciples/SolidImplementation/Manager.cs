using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidImplementation
{
    internal class Manager : Employee
    {
        public Manager()
        {
            Employees = new List<int>();
        }
        public List<int> Employees { get; set; }


    }
}

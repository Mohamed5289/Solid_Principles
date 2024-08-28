using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidImplementation
{
    public static class Print
    {
        public static void Print0<T>(IEnumerable<T> list) 
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}

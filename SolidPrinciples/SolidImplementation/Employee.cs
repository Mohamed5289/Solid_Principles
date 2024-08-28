using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidImplementation
{
    public class Employee
    {
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public string?Name { get; set; }
        public string? City { get; set; }        
        public string? State { get; set; }
        public string? Street { get; set; }
        public DateOnly Hire {  get; set; }
        public decimal Salary { get; set; }


        public Employee() { }


        public override string ToString()
        {
            if(JobTitle is null || Name  is null || City is null || State is null || Street is null )
            {
                return "";
            }

            return $"Job Title {JobTitle.PadLeft(10)} Name {Name.PadLeft(10)} City {City.PadLeft(10)} State {State.PadLeft(10)} Street {Street.PadLeft(10)} ";
        }
    }
}

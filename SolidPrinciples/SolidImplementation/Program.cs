namespace SolidImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9 };


            // Single Responsibility
               Print.Print0(list);


            // Open - Close 

               Employee employee = new Employee();
               Manager manager = new Manager();
            /*
             * Manager inherit from Employee
             */


            // Liskov 
            Employee employee2 = new Manager();


        }
    }
}

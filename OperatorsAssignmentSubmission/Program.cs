using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some Employee objects
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            // Create another Employee object with a different Id
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
            // Create a third Employee object with another different Id
            Employee emp3 = new Employee { Id = 3, FirstName = "Bob", LastName = "Johnson" };

            // Test the overloaded operators compare the Id properties of the Employee objects
            Console.WriteLine("Employee 1 == Employee 2: " + (emp1 == emp2)); // False
            Console.WriteLine("Employee 1 != Employee 3: " + (emp1 != emp3)); // True

            // Pause the console so we can see the output
            Console.ReadLine();
        }
    }
}

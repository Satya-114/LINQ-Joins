using System;
using System.Linq;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var JoinUsingMS = Employee.GetAllEmployees() //Outer Data Source
                           .Join(
                           Address.GetAllAddresses(),  //Inner Data Source
                           employee => employee.AddressId, //Inner Key Selector
                           address => address.ID, //Outer Key selector
                           (employee, address) => new //Projecting the data into a result set
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
}

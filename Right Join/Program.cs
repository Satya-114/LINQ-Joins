using System;
using System.Linq;

namespace LINQ_RightJoin
{
    class Program
    { 
        static void Main(string[] args)
        {
            var QSOuterJoin = from add in Address.GetAddress()
                              join emp in Employee.GetAllEmployees()
                              on add.ID equals emp.AddressId
                              into EmployeeAddressGroup
                              from emp in EmployeeAddressGroup.DefaultIfEmpty()
                              select new { emp, add };

            foreach (var item in QSOuterJoin)
            {
                Console.WriteLine($"Address : {item.add?.AddressLine},\t Name : {item.emp.Name} ");
            }
            Console.ReadLine();
        }
    }
}

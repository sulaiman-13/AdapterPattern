using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class EmployeeDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee> {
            new Employee
            {
                FirstName="Sulaiman",
                SecondName= "Ibrahem",
                LastName= "Ismaeel",
                PayItems=new List<PayItem>{
                new PayItem  {   Name="Basic Salary", Value=200 },
                new PayItem  {   Name="Transportation", Value=20 },
                new PayItem  {   Name="Medical Insurance", Value=20 ,IsDeduction=true},
                }
            },
                new Employee
            {
                FirstName  ="Ibarhem",
                    SecondName="Sulaiman",
                    LastName="Ismaeel",
                PayItems=new List<PayItem>{
                new PayItem  {   Name="Basic Salary", Value=200 },
                new PayItem  {   Name="Transportation", Value=20 },
                new PayItem  {   Name="Medical Insurance", Value=-20 },
                }
            },
            };
        }
    }
}

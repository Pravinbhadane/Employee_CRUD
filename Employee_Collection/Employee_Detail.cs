using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Collection
{
    public class Employee_Detail
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Double Salary { get; set; }
        }

        public class EmployeeCRUD
        {
            private List<Employee> emp;
            public EmployeeCRUD()
            {
                emp = new List<Employee>();
            }

            public void AddEmployee(Employee employees)
            {
                emp.Add(employees);
            }
            public void UpdateEmployee(Employee employees)
            {
                foreach (Employee p in emp)
                {
                    if (p.Id == employees.Id)
                    {
                        
                        p.Name = employees.Name;
                        p.Salary = employees.Salary;
                        break;
                    }
                }
            }

            public void DeleteEmployee(int id)
            {
                foreach (Employee p in emp)
                {
                    if (p.Id == id)
                    {
                        emp.Remove(p);
                        break;
                    }
                }
            }

            public List<Employee> GetEmployees()
            {
                return emp;
            }



        }
    }
}

using System;
using System.Collections.Generic;
using static Employee_Collection.Employee_Detail;

namespace CollectionsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            EmployeeCRUD crud = new EmployeeCRUD();
            int option = 0;
            do
            {

                Console.WriteLine("1. Add Employees");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display All Employees");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Employee p1 = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary");
                        p1.Salary = Convert.ToDouble(Console.ReadLine());

                        crud.AddEmployee(p1);
                        break;

                    case 2:
                 
                        Employee p2 = new Employee();
                        Console.WriteLine("Enter id to modify");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter employee Salary");
                        p2.Salary = Convert.ToDouble(Console.ReadLine());
                        crud.UpdateEmployee(p2);
                        break;
                    case 3:
                     
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id);
                        break;
                    case 4:
                      

                        List<Employee> list = crud.GetEmployees();
                        foreach (Employee p in list)
                        {
                            Console.WriteLine($"{p.Id}--> {p.Name} --> {p.Salary}");
                        }
                        break;
                }

                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option == 1);


        }
    }
}



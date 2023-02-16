using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FirstApp
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees do you want to create?");
            int size = Int32.Parse(Console.ReadLine());
            Employee[] emps = new Employee[size];
            bool isRun = true;
            while(isRun) {
            Console.WriteLine("Please choose operation:\n a.Create new employee\n b.List all employees' info\n c.List employees of one department\n d.Find an employee by name\n e. Exit");
            string operation = Console.ReadLine();
            switch (operation) {
                case "a": 
                     Employee.CreateEmployee(emps);
                    break;
                
                case "b":
                    Employee.ShowAllEmployees(emps);
                    break;
                
                case "c":
                    Console.WriteLine("Please choose department:");
                    int dep = Int32.Parse(Console.ReadLine());
                    Employee.ShowOneDepEmployees(emps, dep);
                    break;
                
                case "d":
                    Console.WriteLine("Please type a name to search:");
                    String searchName = Console.ReadLine();
                    Employee.GetOneEmployee(emps, searchName);
                    break;
                
                case "e":
                    Console.WriteLine("Terminating the program...");
                    isRun = false;
                    break;
                }
            }
        }
    }

    struct Employee {
         public string name;
         public int age;
         public int salary;
         public int department;
         static public int indexCounter = 0;
         static public int sizeController;
        
         public Employee() {
            // this.name = name;
            // this.age = age;
            // this.salary = salary;
            // this.department = dep;
        }

         static public void ShowAllEmployees(Employee[] emps) {
            foreach(Employee e in emps ) {
                Console.WriteLine("Name: "  + e.name + " ," +  "Age: " + e.age + ", " + "Salary: " + e.salary + " ," +  "Department: " + e.department);
            }
            Console.WriteLine("Press any button to return to menu");
            Console.ReadLine();
        }

        static public void ShowOneDepEmployees(Employee[] emps, int dep)
        {
            Console.WriteLine("Employees from department " + " " + dep + ":");
            foreach (Employee e in emps) {
                if (dep == e.department)
                {
                    Console.WriteLine(e.name);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any button to return to menu ");
            Console.ReadLine();
        }

        static public void GetOneEmployee(Employee[] emps, String name) {
            foreach (Employee e in emps) {
                if (name == e.name)
                {
                    Console.WriteLine("Name: "  + e.name + " ," +  "Age: " + e.age + ", " + "Salary: " + e.salary + " ," +  "Department: " + e.department);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any button to return to menu ");
            Console.ReadLine();
        }

        static public void CreateEmployee (Employee[] emps) {
            Console.WriteLine("Number of employees to create: " + " " + emps.Length.ToString());
            Console.WriteLine("Number of employees created: " + " " + sizeController);

            if (sizeController >= emps.Length)
            {
                Console.WriteLine("You cannot create more employees! Press any button to return to menu");
                Console.ReadLine();
            }
            else
            {
                sizeController += 1;
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Age: ");
                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Salary: ");
                int salary = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Department: ");
                int department = Int32.Parse(Console.ReadLine());
                
                Employee emp = new Employee();
                emp.name = name;
                emp.salary = salary;
                emp.age = age;
                emp.department = department;
                emps[indexCounter] = emp;
                indexCounter += 1;
            }
        }
    }
}
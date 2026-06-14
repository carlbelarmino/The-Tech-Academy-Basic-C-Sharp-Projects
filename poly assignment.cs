using System;

namespace PolymorphismAssignment
{
    public interface IQuittable
    {
        void Quit();
    }
    public class Employee: IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has officially quit the company.");
        }
    }
    class Program
    {
        static void Main(string[] args) { 
            //instantiate the employee object with data
        }
        {
            Employee emp = new Employee() { Id = 101, FirstName = "John", LastName = "Doe" };
        //Use Polymorphism to assign the employee to the IQuittable interface
            
            
            IQuittable quittableEmployee = emp;
        //Call the Quit method on the interface object
            {
                Id=101,
                    FirstName="John",
                    LastName="Doe"
            };
            quittableEmployee.Quit();//Pause the console Console.ReadLine();}
            Console.ReadLine();
        }
    }
}



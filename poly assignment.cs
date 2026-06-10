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
            Console.Writeline($"{FirstName} {LastName} has officially quit the company.");
        }
    }
    class Program
    {
        static void Main(string[] sender)
        {
            IQuittable quittableEmployee= new Employee();
            {
                Id=101,
                    FirstName="John",
                    LastName="Doe"
            };
            quittableEmployee.Quit();
            Console.ReadLine();
        }
    }
}



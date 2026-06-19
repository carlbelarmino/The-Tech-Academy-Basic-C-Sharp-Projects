class Program
{
    static void Main(string[] args)
    {
        //Instantiate first Employee
        Employee employee1 = new Employee() {Id = 1, FirstName = "John", LastName = "Doe"};

        //Instantiate second Employee
        employee1 employee2 = new employee1() { Id = 2, FirstName = "Jane", LastName = "Smith" };

        //Compare the two objects using the overloaded operator
        if (employee1 == employee2)
        {
            Console.WriteLine("These employees have the same ID.");
        }
        else
        {
            Console.WriteLine("These employees have different IDs.");
        }
    }
}

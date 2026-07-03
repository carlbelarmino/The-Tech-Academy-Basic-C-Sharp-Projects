using System;
using StudentDatabaseApp;

using (var context = new SchoolContext())
{
    Console.WriteLine("Creating and adding a new Student...");

    //Create a new Student instance
    var newStudent = new Student
    {
        FirstName = "Marcon",
        LastName = "Zymar",
        EnrollmentDate = DateTime.Now
    };
    //Add to the context and save changes to LocalDB/SQL Server
    context.Students.Add(newStudent);
    context.SaveChanges();

    Console.WriteLine("Student saved successfully!");
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

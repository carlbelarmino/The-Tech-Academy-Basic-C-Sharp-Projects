using System;
namespace StudentDatabaseApp
{
    public class Student
    {
        //Entity Framework automatically treats 'Id' as the primary key
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
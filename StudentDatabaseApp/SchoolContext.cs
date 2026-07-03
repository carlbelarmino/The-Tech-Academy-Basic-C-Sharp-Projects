using System.Data.Entity;
namespace StudentDatabaseApp
{
    public class SchoolContext:DbContext
    {
        //Connection string name can be passed to the base constructor
        public SchoolContext(): base("name=SchoolDBConnectionString")
        {

        }
        //This represents the Student table in your database
        public DbSet<Student> Students { get; set; }
    }
}
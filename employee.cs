using System;

namespace OperatorsAssignment
{
	//Create an Employee class with ID, FirstName, and LastName propoerties
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		//Overload the "==" operator to compare Employee objects by their Id property
		public static bool operator ==(Employee emp1, Employee emp2)
		{
			//Handle null checks to avoid NullReferenceException
			if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
			{
				return true;
			}
			if (ReferenceEquals(emp1, null))
			{
				return false;
			}

			// Return true if the IDs match,
			return emp1.Id == emp2.Id;
		}

		// Comparison operator must be overloaded in pairs (== and !=)
		public static bool operator !=(Employee emp1, Employee emp2)
		{
			// Return the opposite result of the == operator
			return !(emp1 == emp2);
		}

		// Best practice: Always override Equal and GetHashCode when overloading ==
		public override bool Equals(object obj)
		{
			if (obj is Employee employee)
			{
				return this.Id == employee.Id;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}

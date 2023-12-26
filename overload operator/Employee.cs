using System;


namespace overload_operator
{
    //created an Employee class with Id, First Name and Last Name properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //overload "==" operator to compare two Employee objects by their Id property
        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }
            return employee1.Id == employee2.Id;
        }
        public static bool operator != (Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}

namespace Problem1ClassStudent
{
    using System.Collections.Generic;

    internal class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }
    }
}
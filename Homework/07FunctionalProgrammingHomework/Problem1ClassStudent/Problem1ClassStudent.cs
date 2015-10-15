namespace Problem1ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem1ClassStudent
    {
        private static bool ChechForMarks(IList<int> collection, int _number)
        {
            bool result = false;
            foreach (var item in collection)
            {
                if (item == _number)
                {
                    result = true;
                    return result;
                }
            }

            return result;
        }

        private static bool ChechMoreMarks(IList<int> collection, int _number)
        {
            bool result = false;
            for (int i = 1; i < collection.Count - 1; i++)
            {
                if (collection[i - 1] == _number && collection[i] == _number)
                {
                    result = true;
                    return result;
                }

                if (collection[i] == _number && collection[i + 1] == _number)
                {
                    result = true;
                    return result;
                }

                if (collection[i - 1] == _number && collection[i + 1] == _number)
                {
                    result = true;
                    return result;
                }
            }

            return result;
        }

        private static void Main()
        {
            List<Student> students = new List<Student>();

            var student = new Student
                              {
                                  FirstName = "Ceco", 
                                  LastName = "Cekov", 
                                  Age = 32, 
                                  FacultyNumber = "215314", 
                                  Phone = "0254867541", 
                                  Email = "ceko@abv.bg", 
                                  GroupNumber = 2, 
                                  Marks = new List<int> { 3, 3, 2 }
                              };
            var student1 = new Student
                               {
                                   FirstName = "Sasho", 
                                   LastName = "Petkov", 
                                   Age = 32, 
                                   FacultyNumber = "211332", 
                                   Phone = "0257567541", 
                                   Email = "aleks@abv.bg", 
                                   GroupNumber = 1, 
                                   Marks = new List<int> { 2, 3, 2 }
                               };
            var student2 = new Student
                               {
                                   FirstName = "Misho", 
                                   LastName = "Despotov", 
                                   Age = 36, 
                                   FacultyNumber = "211314", 
                                   Phone = "+359456268895", 
                                   Email = "Mishoo@abv.bg", 
                                   GroupNumber = 2, 
                                   Marks = new List<int> { 5, 4, 5 }
                               };
            var student3 = new Student
                               {
                                   FirstName = "Milena", 
                                   LastName = "Petkova", 
                                   Age = 30, 
                                   FacultyNumber = "223327", 
                                   Phone = "+359434534668895", 
                                   Email = "milenaPet@gmail.com", 
                                   GroupNumber = 1, 
                                   Marks = new List<int> { 6, 6, 5 }
                               };
            var student4 = new Student
                               {
                                   FirstName = "Pavkata", 
                                   LastName = "Blagoev", 
                                   Age = 27, 
                                   FacultyNumber = "258167", 
                                   Phone = "+3594545645695", 
                                   Email = "pblagoev@gmail.com", 
                                   GroupNumber = 3, 
                                   Marks = new List<int> { 5, 4, 5 }
                               };
            var student5 = new Student
                               {
                                   FirstName = "Bojidar", 
                                   LastName = "Kosev", 
                                   Age = 22, 
                                   FacultyNumber = "111367", 
                                   Phone = "+3592562695", 
                                   Email = "caskfor@abv.bg", 
                                   GroupNumber = 3, 
                                   Marks = new List<int> { 4, 3, 3 }
                               };
            var student6 = new Student
                               {
                                   FirstName = "Stoqn", 
                                   LastName = "Katinarov", 
                                   Age = 18, 
                                   FacultyNumber = "256377", 
                                   Phone = "+3594289348895", 
                                   Email = "100kti@abv.bg", 
                                   GroupNumber = 1, 
                                   Marks = new List<int> { 3, 4, 2 }
                               };
            var student7 = new Student
                               {
                                   FirstName = "Nasko", 
                                   LastName = "Gospodinov", 
                                   Age = 39, 
                                   FacultyNumber = "176367", 
                                   Phone = "+3594562123546", 
                                   Email = "naskogospo@abv.bg", 
                                   GroupNumber = 2, 
                                   Marks = new List<int> { 4, 6, 5 }
                               };
            var student8 = new Student
                               {
                                   FirstName = "Jens", 
                                   LastName = "Botcher", 
                                   Age = 45, 
                                   FacultyNumber = "276514", 
                                   Phone = "+017684595245", 
                                   Email = "jensBo@gmail.com", 
                                   GroupNumber = 3, 
                                   Marks = new List<int> { 4, 4, 3 }
                               };
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);

            // -------- Problemes 2 - 10 ----------//
            Console.WriteLine("Problem 2\n");

            var problem2StudentsbyGroup = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            foreach (Student st in problem2StudentsbyGroup)
            {
                Console.WriteLine("First Name: {0} Group number is: {1}", st.FirstName, st.GroupNumber);
            }

            Console.WriteLine("\nProblem 3\n");

            var problem3StudentsbyFirstAndLastName =
                students.OrderBy(st => st.FirstName).Where(st => st.FirstName.CompareTo(st.LastName) < 0);

            foreach (Student st in problem3StudentsbyFirstAndLastName)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }

            Console.WriteLine("\nProblem 4\n");

            var problem4StudentsbyAge =
                students.Where(st => st.Age >= 18 && st.Age <= 24).OrderBy(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (Student st in problem4StudentsbyAge)
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Age: {2}", st.FirstName, st.LastName, st.Age);
            }

            Console.WriteLine("\nProblem 5\n");

            var problem5SotStudents =
                students.Where(st => st.Age >= 0 && st.Age <= 100)
                    .OrderByDescending(st => st.FirstName)
                    .ThenBy(st => st.LastName);
            foreach (Student st in problem5SotStudents)
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Age: {2}", st.FirstName, st.LastName, st.Age);
            }

            Console.WriteLine("\nProblem 6\n");

            var problem6StudentsByEmail = students.Where(st => st.Email.EndsWith("@abv.bg")).OrderBy(st => st.Email);
            foreach (Student st in problem6StudentsByEmail)
            {
                Console.WriteLine("E-mail adress is: {0} ", st.Email);
            }

            Console.WriteLine("\nProblem 7\n");

            var problem7FilterByPhone = students.Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592")).OrderBy(st => st.Phone);
            foreach (Student st in problem7FilterByPhone)
            {
                Console.WriteLine("Phone number is: {0} Last Name: {1}", st.Phone, st.LastName);
            }

            Console.WriteLine("\nProblem 8\n");

            var problem8ExcellentStudents = students.Where(st => ChechForMarks(st.Marks, 6));

            foreach (Student st in problem8ExcellentStudents)
            {
                Console.Write("First Name: {0} Last Name: {1} Marks are:", st.FirstName, st.LastName);
                foreach (int marks in st.Marks)
                {
                    Console.Write(" {0} ", marks);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nProblem 9\n");


            var problem9WeakStudents = students.Where(st => ChechMoreMarks(st.Marks, 2));

            var problem9 = students.Where(x => x.Marks.Count(y => y == 2) == 2); //s Lambda bez da si pravq method
            
            foreach (Student st in problem9WeakStudents)
            {
                Console.Write("First Name: {0} Last Name: {1} Marks are:", st.FirstName, st.LastName);
                foreach (int marks in st.Marks)
                {
                    Console.Write(" {0} ", marks);
                }

                Console.WriteLine();
            }


            Console.WriteLine("\nProblem 10\n"); // ili string pattern = @"(?<=\d{4})(14)";

            var problem10StudentEnrolled =
                students.Where(st => st.FacultyNumber.EndsWith("14")).OrderBy(st => st.FirstName);
            foreach (Student st in problem10StudentEnrolled)
            {
                Console.WriteLine(
                    "First Name: {0} Last Name: {1} Faculty Number is: {2}", 
                    st.FirstName, 
                    st.LastName, 
                    st.FacultyNumber);
            }
        }
    }
}
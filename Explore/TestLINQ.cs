using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// resources
// https://www.tutorialsteacher.com/linq/linq-grouping-operator-groupby-tolookup
namespace LearningCSharp.Explore
{
    class TestLINQ
    {
        static void Main(string[] args)
        {
            List<Student> students = GetDummyStudents();
            // these LINQ extention methods work with array.


            // Use LINQ to find teenager students
            Console.WriteLine("get teenagers");
            List<Student> teenagers = students.Where(s => s.Age >= 12 && s.Age < 20).ToList<Student>();
            teenagers.ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("FirstOrDefault");
            Student bill = students.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine(bill);
            Console.WriteLine();

            Console.WriteLine("FirstOrDefault");
            Student numberFive = students.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(numberFive);
            Console.WriteLine();

            Console.WriteLine("OrderBy");
            students.
                OrderBy(student => student.Age).
                ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy");
            students.
                OrderByDescending(student => student.Age).
                ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy, ThenBy");
            students.
                OrderBy(student => student.StudentName).
                ThenBy(student => student.Age)
                .ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy, ThenBy");
            students.
                OrderBy(student => student.StudentName).
                ThenByDescending(student => student.Age)
                .ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("GroupBy");
            var groups = students.GroupBy(student => student.Age);
            foreach (var group in groups)
            {
                Console.WriteLine($"age group: {group.Key}");
                foreach (Student student in group) Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("LookUp");
            var groups2 = students.ToLookup(student => student.Age);
            foreach (var group in groups2)
            {
                Console.WriteLine($"age group: {group.Key}");
                foreach (Student student in group) Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("Select");
            var resultsSelect = students.Select(student => new
            {
                Name = student.StudentName,
                Age = student.Age
            });
            foreach (var result in resultsSelect)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            Console.WriteLine("All, Any");
            Console.WriteLine(students.All(s => s.Age >= 12 && s.Age < 20));
            Console.WriteLine(students.Any(s => s.Age >= 12 && s.Age < 20));
            Console.WriteLine();

            Console.WriteLine("Contain");
            // it only compares reference of an object
            Console.WriteLine(students.Contains(new Student() { StudentID = 3, StudentName = "Bill", Age = 25 }));
            // in order to compare actual values of an object, need to implement IEqualityComparer.
            Console.WriteLine(students.Contains(new Student() { StudentID = 3, StudentName = "Bill", Age = 25 }, new StudentComparer()));
            Console.WriteLine();

            Console.WriteLine("Take");
            // take 2 from the list
            students.Take(2).ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine("TakeWhile");
            // takes from the list until the specified condition is true...
            // in this case, only returns a student, since there is 18-years old John placed in the first and Ram is on the last.
            students.TakeWhile(student => student.Age == 18).ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("Skip");
            // take 2 from the list
            students.Skip(2).ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine("SkipWhile");
            // takes from the list until the specified condition is true...
            // in this case, only returns a student, since there is 18-years old John placed in the first and Ram is on the last.
            students.SkipWhile(student => student.Age < 20).ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();


            List<Student> students2 = new List<Student>() {
                students[0],
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 10, StudentName = "James" , Age = 30 } ,
            };


            Console.WriteLine("Intersect");
            {
                var results = students.Intersect(students2);
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine("Intersect (with IEqualityComparer)");
            {
                var results = students.Intersect(students2, new StudentComparer());
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Except");
            {
                var results = students.Except(students2, new StudentComparer());
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Union, Distinct");
            {
                var results = students.Union(students2).Distinct(new StudentComparer());
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sum, Max, Avg");
            // get the sum of ages of people who are older than 21.
            Console.WriteLine(students.Sum(s =>
            {
                if (s.Age > 21) return s.Age;
                else return 0;
            }));
            // get the max age of people who are younger than 21.
            Console.WriteLine(students.Max(s =>
            {
                if (s.Age < 21) return s.Age;
                else return 0;
            }));
            // get the average age of "Ram"
            Console.WriteLine(students.Average(s =>
            {
                if (s.StudentName.Equals("Ram")) return s.Age;
                else return null;
            }));
            Console.WriteLine();
        }

        class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentID == y.StudentID &&
                    x.Age == y.Age &&
                    string.Equals(x.StudentName, y.StudentName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.StudentID.GetHashCode();
            }
        }

        static List<Student> GetDummyStudents()
        {
            return new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
        }

        class Student
        {
            public int StudentID { get; set; }
            public String StudentName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{StudentID} {StudentName} {Age}";
            }
        }
    }
}
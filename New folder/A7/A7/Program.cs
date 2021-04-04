using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace A7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Course[] courses = FileReadUtil.readDataFromCsvCourse("Courses.csv");


            // Question 1.2 part a
            Console.WriteLine("Q1.2 a: ");
            var ieeCourses =
                from b in courses
                where b.Subject == "IEE" && b.Code >= 300
                orderby b.Instructor
                select new { title=b.Title, instructor=b.Instructor };


            foreach(var course in ieeCourses)
            {
                Console.WriteLine("\tCourse Title: {0}, Instructor: {1}", course.title, course.instructor);
            }
            // End Question 1.2 part a

            // Question 1.2 part b
            Console.WriteLine("Question 1.2 Part B:");

            var courseGroups =
                from c in courses
                group c by c.Subject into g1
                select new { Subject = g1.Key,
                    subGroup = from c in g1 
                               group c by c.Code into g2
                               where g2.Count() >= 2
                               select g2.Key
                    };

            foreach (var course in courseGroups)
            {
                Console.WriteLine("\t" + course.Subject);
                foreach (var code in course.subGroup)
                {
                    Console.WriteLine("\t\t" + code);
                }
                
            }
            // End Questions 1.2 part b

            // Question 1.4 part 2
            Instructor[] instructors = FileReadUtil.readDataFromCsvInstructor("Instructors.csv");
                

            Console.WriteLine("stop");


        }
    }
}

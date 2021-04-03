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
            CourseDb courseDb = new CourseDb();
            Course[] courses = courseDb.readDataFromCsv("Courses.csv");


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


        }
    }
}

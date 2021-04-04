using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A7
{
    class FileReadUtil
    {
     
        public static Course[] readDataFromCsvCourse(string filename)
        {

            List<Course> courses = new List<Course>();
            // Answers 2nd half of question 1.1: Read data from csv
            StreamReader sr = new StreamReader(filename);
            string line;
            string[] row;
            line = sr.ReadLine(); // skip the first line since it is a header
            while ((line = sr.ReadLine()) != null){
                row = line.Split(',');
                Course course = new Course();
                course.Subject = row[0].Split(' ')[0].Trim();
                course.Code = Int32.Parse(row[0].Split(' ')[1]);
                course.Title = row[1].Trim();
                course.CourseId = Int32.Parse(Regex.Replace(row[2], @"[^\d]", ""));
                course.Instructor = row[3].Trim();
                course.Location = row[7].Trim();

                courses.Add(course);

            }

            sr.Close();

            return courses.ToArray();
        }

        public static Instructor[] readDataFromCsvInstructor(string filename)
        {
            List<Instructor> instructors = new List<Instructor>();
            // Answers 2nd half of question 1.4: Read instructor data from csv
            StreamReader sr = new StreamReader(filename);
            string line;
            string[] row;
            line = sr.ReadLine(); // skip the first line since it is a header
            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',');
                Instructor instructor = new Instructor();
                instructor.name = row[0].Trim();
                instructor.office = row[1].Trim();
                instructor.email = row[2].Trim();

                instructors.Add(instructor);

            }

            sr.Close();

            return instructors.ToArray();
        }
    }
}

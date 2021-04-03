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
    class CourseDb
    {
        public List<Course> courses;

        public CourseDb()
        {
            courses = new List<Course>();
        }
        public Course[] readDataFromCsv(string filename)
        {
            // Answers 2nd half of question 1.1: Read data from csv
            StreamReader sr = new StreamReader(filename);
            string line;
            string[] row;
            line = sr.ReadLine(); // skip the first line since it is a header
            while ((line = sr.ReadLine()) != null){
                row = line.Split(',');
                Course course = new Course();
                course.Subject = row[0].Split(' ')[0];
                course.Code = Int32.Parse(row[0].Split(' ')[1]);
                course.Title = row[1];
                course.CourseId = Int32.Parse(Regex.Replace(row[2], @"[^\d]", ""));
                course.Instructor = row[3];
                course.Location = row[7];

                courses.Add(course);

            }

            sr.Close();

            return courses.ToArray();
        }
    }
}

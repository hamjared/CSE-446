using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8
{
    class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = FileReadUtil.readDataFromCsvCourse("App_Data/Courses.csv");
            //Q2.1 and 2.2
            XMLConverter.writeXmlFile(courses);
        }
    }
}

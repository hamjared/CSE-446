using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace A8
{
    class XMLConverter
    {

        public static void writeXmlFile(Course[] courses)
        {
          
            XmlTextWriter writer = null;

            try
            {
                
                writer = new XmlTextWriter("Courses.xml", System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Courses");
                foreach (Course course in courses)
                {
                    writer.WriteStartElement("Course");
                    writer.WriteElementString("Subject", course.Subject);
                    writer.WriteElementString("Code", course.Code.ToString());
                    writer.WriteElementString("CourseId", course.CourseId.ToString());
                    writer.WriteElementString("Title", course.Title);
                    writer.WriteElementString("Location", course.Location);
                    writer.WriteElementString("Instructor", course.Instructor);
                    writer.WriteEndElement();
                   
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

            }
            finally
            {
               
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }
}

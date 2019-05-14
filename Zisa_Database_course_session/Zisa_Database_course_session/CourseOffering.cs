using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zisa_Database_course_session
{
    public class CourseOffering
    {
        public string SessionCode { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public int SectionNumber {get;set;}
        public int EmployeeNumber { get; set; }
        public int Capacity { get; set; }

        public CourseOffering()
        {
            SectionNumber = 1;
            EmployeeNumber = 3514239;
            Capacity = 40;
        }
    }
}

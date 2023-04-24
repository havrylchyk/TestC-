using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formationofgroups.Domain
{
    public class CourseRegistration
    {
        public DateTime CreatedDate { get; set; }
        public ElectiveCourse _ElectiveCourse { get; set; }
        public Student Student { get; set; }
        public int YearOfStudy { get; set; }
        public string Status { get; set; }

        public CourseRegistration(DateTime createdDate, ElectiveCourse ElectiveCourse, Student student, int yearOfStudy, string status)
        {
            _ElectiveCourse = ElectiveCourse;
            CreatedDate = createdDate;
            Student = student;
            YearOfStudy = yearOfStudy;
            Status = status;
        }
    }
}

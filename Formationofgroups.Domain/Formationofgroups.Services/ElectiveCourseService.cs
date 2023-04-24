using Formationofgroups.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formationofgroups.Services
{
    public class ElectiveCourseService
    {
        public List<ElectiveCourse> CourseList;

        public ElectiveCourseService()
        {
            CourseList = new List<ElectiveCourse>
            {
                new ElectiveCourse("розробка сайтів", 5, 20, 2),
                new ElectiveCourse("Мобільний дизайн", 4, 15, 1),
                new ElectiveCourse("Штучний інтелект в бізнесі", 3, 10, 3),
                new ElectiveCourse("Криптографія та інформаційна безпека", 4, 20, 2)
            };
        }
    }
}

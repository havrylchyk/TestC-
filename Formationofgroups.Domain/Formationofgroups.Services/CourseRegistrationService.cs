using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formationofgroups.Domain;

namespace Formationofgroups.Services
{
    public class CourseRegistrationService
    {
        // Сервіс для роботи з записами на курси

        public List<CourseRegistration> _registrations;
        public CourseRegistrationService()
        {
            _registrations = new List<CourseRegistration>();
        }
        //Перевірка чи студент може бути записаним на курс
        //рік курсу = рік курсу для якого читається цей предмет
        //Перевірка чи уже записаний студент 
        // Записати студента на курс
        public void RegisterStudent(Student student, ElectiveCourse course)
        {
            if (CheckDataToRegistration(student, course) == true)
            {
                DateTime now = DateTime.Now;
                CourseRegistration registration = new CourseRegistration(now, course, student, 2, "В очікуванні");
                _registrations.Add(registration);
            }
        }

        public bool CheckDataToRegistration(Student student, ElectiveCourse course)
        {
            int count = 0;
            //Перевірка року навчання студента
            if (student.Group.YearOfStudy != course.YearOfStudy)
            {
                count++;//Студент не може бути записаний на даний курс, тому що він не навчається на цьому курсі
            }

            //Перевірка чи студент вже записаний на курс
            foreach (CourseRegistration registration in _registrations)
            {
                if (registration.Student == student && registration._ElectiveCourse == course)
                {
                    count++;//Студент вже зареєстрований на даний курс.
                }
            }
            if (count > 0) return false;
            else return true;
        }

        // Отримати список записів на курс
        public List<CourseRegistration> GetRegistrations()
        {
            return _registrations;
        }
        // Оновити статус запису на курс
        public void UpdateRegistrationStatus(CourseRegistration registration, string status)
        {
            registration.Status = status;
        }

    }
}


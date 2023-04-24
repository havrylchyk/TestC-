using Formationofgroups.Domain;
using System;
using System.Collections.Generic;

namespace Formationofgroups.Services
{
    public class StudentService
    {
        public List<Student> StudentList;

        public StudentService(List<GroupOfStudents> groupList)
        {
            StudentList = new List<Student>
            {
                new Student("Петренко", "Володимир", DateOnly.Parse("01.01.2005"), groupList[0]),
                new Student("Іваненко", "Марія", DateOnly.Parse("05.02.2005"), groupList[0]),
                new Student("Сидоренко", "Олександр", DateOnly.Parse("10.03.2005"), groupList[0]),
                new Student("Петров", "Олексій", DateOnly.Parse("15.04.2005"), groupList[0]),
                new Student("Коваленко", "Ірина", DateOnly.Parse("20.05.2005"), groupList[0]),
                new Student("Сергієнко", "Андрій", DateOnly.Parse("25.06.2005"), groupList[0]),
                new Student("Козак", "Юлія", DateOnly.Parse("01.07.2005"), groupList[0]),
                new Student("Бойко", "Дмитро", DateOnly.Parse("05.08.2005"), groupList[0]),
                new Student("Кравченко", "Оксана", DateOnly.Parse("10.09.2005"), groupList[0]),
                new Student("Шевченко", "Тарас", DateOnly.Parse("15.10.2005"), groupList[0]),

                new Student("Іваненко", "Олександр", DateOnly.Parse("12.04.2004"), groupList[1]),
                new Student("Сидоренко", "Юлія", DateOnly.Parse("23.06.2004"), groupList[1]),
                new Student("Бондаренко", "Андрій", DateOnly.Parse("05.10.2004"), groupList[1]),
                new Student("Мельник", "Вікторія", DateOnly.Parse("17.07.2004"), groupList[1]),
                new Student("Коваль", "Олег", DateOnly.Parse("03.02.2004"), groupList[1]),
                new Student("Шевчук", "Марія", DateOnly.Parse("11.12.2004"), groupList[1]),
                new Student("Білоус", "Анна", DateOnly.Parse("29.09.2004"), groupList[1]),
                new Student("Тарасенко", "Ігор", DateOnly.Parse("22.05.2004"), groupList[1]),
                new Student("Коваленко", "Юрій", DateOnly.Parse("28.08.2004"), groupList[1]),
                new Student("Павленко", "Олена", DateOnly.Parse("07.03.2004"), groupList[1]),

                new Student("Кравченко", "Ігор", DateOnly.Parse("10.02.2003"), groupList[2]),
                new Student("Іванова", "Олена", DateOnly.Parse("18.06.2003"), groupList[2]),
                new Student("Коваленко", "Олександр", DateOnly.Parse("24.09.2003"), groupList[2]),
                new Student("Морозов", "Андрій", DateOnly.Parse("05.07.2003"), groupList[2]),
                new Student("Литвиненко", "Марія", DateOnly.Parse("15.12.2003"), groupList[2]),
                new Student("Сидорова", "Юлія", DateOnly.Parse("27.04.2003"), groupList[2]),
                new Student("Бондар", "Максим", DateOnly.Parse("03.11.2003"), groupList[2]),
                new Student("Іщенко", "Олексій", DateOnly.Parse("12.03.2003"), groupList[2]),
                new Student("Карпенко", "Ірина", DateOnly.Parse("08.08.2003"), groupList[2]),
                new Student("Харченко", "Юлія", DateOnly.Parse("20.01.2003"), groupList[2])
            };

        }
    }
}

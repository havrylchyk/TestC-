using System;

namespace Formationofgroups.Domain
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateOnly YearsOfBirth { get; set; }
        public GroupOfStudents Group { get; set; }

        public Student(string lastName, string firstName, DateOnly birthDate, GroupOfStudents group)
        {
            SecondName = lastName;
            FirstName = firstName;
            YearsOfBirth = birthDate;
            Group = group;
        }
    }
}

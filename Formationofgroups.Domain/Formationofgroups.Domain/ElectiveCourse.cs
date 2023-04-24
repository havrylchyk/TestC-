namespace Formationofgroups.Domain
{
    public class ElectiveCourse
    {
        public string NameOfCourse { get; set; }
        public int AmountOfLectures { get; set; }
        public int AmountOfLessons { get; set; }
        public int YearOfStudy { get; set; }

        public ElectiveCourse(string name, int numberOfLectures, int numberOfLessons, int year)
        {
            NameOfCourse = name;
            AmountOfLectures = numberOfLectures;
            AmountOfLessons = numberOfLessons;
            YearOfStudy = year;
        }
    }
}

namespace Formationofgroups.Domain
{
    public class GroupOfStudents
    {
        public string Name { get; set; }
        public int YearOfStudy { get; set; }

        public GroupOfStudents(string name, int year)
        {
            Name = name;
            YearOfStudy = year;
        }
    }

    
}

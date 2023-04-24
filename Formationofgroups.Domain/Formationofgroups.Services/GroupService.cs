using Formationofgroups.Domain;
using System.Collections.Generic;

namespace Formationofgroups.Services
{
    public class GroupService
    {
        public List<GroupOfStudents> GroupList;

        public GroupService()
        {
            GroupList = new List<GroupOfStudents>
            {
                new GroupOfStudents("КН-11", 1),
                new GroupOfStudents("КН-21", 2),
                new GroupOfStudents("КН-31", 3)
            };
        }
    }
}

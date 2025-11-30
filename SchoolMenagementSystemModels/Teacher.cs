using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack.DataAnnotations;

namespace S.M.S.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Selected { get; set; }

        [Unique]
        public string KeyId { get; set; }
        public string Qualification { get; set; }
        public int YearsOfExperience { get; set; }
        public ICollection<AssignGrade> AssignGrades { get; set; }

        public ICollection<TeacherSession> TeacherSessions
        {
            get; set;
        }

    }
}

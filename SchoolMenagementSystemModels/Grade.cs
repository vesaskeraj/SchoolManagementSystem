using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace S.M.S.Models
{
    public  class Grade
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public ICollection<AssignGrade> AssignGrades { get; set; } = new HashSet<AssignGrade>();

        [NotMapped]
        public ICollection<Enroll> Enrolls { get; set; } = new HashSet<Enroll>();

        public ICollection<GradeSubject> GradeSubjects { get; set; }



    }
}

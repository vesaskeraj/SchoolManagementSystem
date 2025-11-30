using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace S.M.S.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public ICollection<GradeSubject> GradeSubject { get; set; }
    }
}

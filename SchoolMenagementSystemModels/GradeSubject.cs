using System;
using System.Collections.Generic;
using System.Text;

namespace S.M.S.Models
{
    public class GradeSubject
    {
        public int ID { get; set; }
        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }
        public int? SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}

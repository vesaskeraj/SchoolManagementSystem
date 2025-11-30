using System;
using System.Collections.Generic;
using System.Text;

namespace S.M.S.Models
{
    public class AssignGrade
    {
        public int Id { get; set; }
        public int? GradeId {  get; set; }
        public Grade? Grade { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}

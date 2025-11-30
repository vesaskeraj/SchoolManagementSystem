using System;
using System.Collections.Generic;
using System.Text;

namespace S.M.S.Models
{
    public class TeacherSession
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int? SessionId { get; set; }
        public Session? Session { get; set; }

    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DB
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdTeacher { get; set; }

        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}

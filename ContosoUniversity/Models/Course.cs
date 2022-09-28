﻿using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Titel { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

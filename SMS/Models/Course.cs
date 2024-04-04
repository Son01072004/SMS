using SMS.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Collection navigation property
    }
}
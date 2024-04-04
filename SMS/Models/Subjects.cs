namespace SMS.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace SMS.Models
    {
        public class Subject
        {
            [Key]
            public int SubjectId { get; set; }
            public string Name { get; set; }
            public int CourseId { get; set; } // Foreign key

            public Course Course { get; set; } // Navigation property

            public ICollection<Subject> Subjects { get; set; }
        }
    }
}

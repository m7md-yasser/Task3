namespace Entity_Core
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public int Credits { get; set; }
        public int TeacherId { get; set; }

        public Teacher? Teacher { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
    }

}

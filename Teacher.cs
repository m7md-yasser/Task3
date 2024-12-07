namespace Entity_Core
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<Course>? Courses { get; set; }
    }
}

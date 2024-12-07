namespace Entity_Core
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string? GradeName { get; set; }

        public Enrollment? Enrollment { get; set; }
    }

}

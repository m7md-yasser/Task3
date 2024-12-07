namespace Entity_Core
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public List<Teacher>? Teachers { get; set; }
    }

}

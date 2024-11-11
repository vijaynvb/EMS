using DataAnnotationsExtensions;

namespace EMSApi.DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        //[Min(18, ErrorMessage ="Age should be More than 18")]
        public int Age { get; set; }// 0 -?
        public int DepartmentId { get; set; }

        [Email(ErrorMessage ="My Error message")]
        public string Email { get; set; }
    }
}

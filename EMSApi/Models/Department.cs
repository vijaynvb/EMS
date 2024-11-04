using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMSApi.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        [Column("DepartmentName", TypeName = "ntext")]
        public string Name { get; set; }

        public Department()
        {

        }

    }
}

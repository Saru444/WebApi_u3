using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Department
    {
        [Key]
        public string Name { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeRefId { get; set; }             
        public  Employee Employee { get; set; }
        public ICollection<DepartmentProduct> Products { get; set; }

    }
}

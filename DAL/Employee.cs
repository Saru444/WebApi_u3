using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public int ID { get; set; }
        public int PersonNumber { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string TelNr { get; set; }
        public int? TrainerID { get; set; }
        public virtual Employee Trainer { get; set; }
        public virtual List<Employee> Staffs { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TrainedDate { get; set; }        
        public ICollection<Department> Departments { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<EmployeeMail> Mails { get; set; }
    }
}

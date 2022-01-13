using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeMail
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string Email { get; set; }
    }
}

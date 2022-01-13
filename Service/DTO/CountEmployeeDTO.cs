using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class CountEmployeeDTO
    {
        public List<EmployeeListDTO> EmployeeList { get; set; }
        public int EmployeeCount{ get; set; }
    }
}

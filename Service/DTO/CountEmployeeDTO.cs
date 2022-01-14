using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class CountEmployeeDTO
    {       
        public int EmployeeCount{ get; set; }
        public List<EmployeeListDTO> EmployeeList { get; set; }
        public CountEmployeeDTO()
        {
            this.EmployeeList = new();
        }
    }
}

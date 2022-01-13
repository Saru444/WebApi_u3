using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentProduct
    {
        public string DepartmentName { get; set; }
        public Department Department { get; set; }
        public int ProductBarcode{ get; set; }
        public Product Product { get; set; }

    }
}

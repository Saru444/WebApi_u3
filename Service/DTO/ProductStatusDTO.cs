using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class ProductStatusDTO
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public ProductStatusDTO()
        {
            this.Status = Status;
        }
    }
}

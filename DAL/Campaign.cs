using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Campaign
    {
        public int Id { get; set; }
        public double Discount { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

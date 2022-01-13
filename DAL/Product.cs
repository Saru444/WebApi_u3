using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        [Key]
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }
        [ForeignKey("Employee")]
        public int InventoriedID { get; set; }
        public Employee Inventoried { get; set; }
        [Column(TypeName = "date")]
        public DateTime InventoriedDate { get; set; }
        [ForeignKey("Campaign")]
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
        public ICollection<DepartmentProduct> Departments { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}

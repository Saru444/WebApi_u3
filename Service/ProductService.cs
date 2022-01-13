using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO;

namespace Service
{
    public class ProductService
    {
        public List<ProductDTO> ListAllProducts()
        {
            List<ProductDTO> pDto = new();

            using (var context = new StoreContext())
            {                
                var result= context.Products
                 .OrderBy(x => x.Quantity)
                 .ToList();
                foreach (var item in result)
                {
                    pDto.Add(new ProductDTO() { Name = item.Name, Quantity = item.Quantity });
                }
                return pDto;
            }       
        }
        public void ChangeQuantity(int barcode, int newQuantity)
        {
            using var context = new StoreContext();
            var result = context.Products.First(x => x.Barcode == barcode);
            result.Quantity = newQuantity;
            context.SaveChanges();
        }
    }
}

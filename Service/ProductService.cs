using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class ProductService
    {
        public List<ProductStatusDTO> ListAllProducts()
        {
            List<ProductStatusDTO> pDto = new();

            using (var context = new StoreContext())
            {
                var result = context.Products
                 .OrderBy(x => x.Quantity)
                 .ToList();
                string status = "OK";
                foreach (var item in result)
                {
                    if (item.Quantity > 3)
                    {
                        status = "OK";
                    }
                    else if (item.Quantity < 3 && item.Quantity > 1)
                    {
                        status = "Snart slut";
                    }
                    else if (item.Quantity == 0)
                    {
                        status = "Slut";
                    }
                    pDto.Add(new ProductStatusDTO() { Name = item.Name, Quantity = item.Quantity, Status = status });
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
        public List<ProductDTO> GetProductInfo(string department, int count)
        {
            List<ProductDTO> proDto = new();
            using (var context = new StoreContext())
            {
                var result = context.Products
                    .Where(x => x.Quantity <= count && (x.Departments.Any(x => x.DepartmentName == department)))
                    .Include(x => x.Departments)
                    .Select(x => new ProductDTO
                    {
                        Name = x.Name,
                        Count = x.Quantity
                    })
                .ToList();
                return result;
            }
        }
    }
}

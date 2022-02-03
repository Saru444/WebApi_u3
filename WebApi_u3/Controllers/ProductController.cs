using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi_u3.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("count")]
        public List<ProductStatusDTO> List()
        {
            var service = new ProductService();

            return service.ListAllProducts();
        }
        [HttpPost("update")]
        public void Update(UpdateQuantity updateQuantity)
        {
            var service = new ProductService();
            service.ChangeQuantity(updateQuantity);
        }
        [HttpGet("list")]
        public List<ProductDTO> ListProducts(string department, int count)
        {
            var service = new ProductService();
            return service.GetProductInfo(department,count);           
        }
    }
}

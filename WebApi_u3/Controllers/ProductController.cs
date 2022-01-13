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
        public List<ProductDTO> List()
        {
            var service = new ProductService();

            return service.ListAllProducts();

        }
        [HttpPut("update/{barcode}")]
        public void Update(int barcode, int newQuantity)
        {
            var service = new ProductService();
            service.ChangeQuantity(barcode, newQuantity);
        }      
    }
}

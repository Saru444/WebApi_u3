using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_u3.Controllers
{
    //[Route("api")]
    //[ApiController]
    //public class API : ControllerBase
    //{
    //    [HttpGet]
    //    public List<Product> List()
    //    {
    //        var service = new ProductService();
    //        return service.ListAllTrains();

    //    }
    //    [HttpGet("{barcode}")]
    //    public void Get(int barcode)
    //    {
    //        var service = new ProductService();
    //        return serviece.GetProduct(barcode);
    //    }
    //    [HttpPost]
    //    public void Create(ProductDTO product)
    //    {
    //        var service = new ProductService();
    //        service.CreateProduct(
    //               new Product
    //               {
    //                   Barcode = product.Barcode,
    //                   Name = product.Name,
    //                   Quantity = product.Quantity
    //               }
    //            );
    //    }
    //    [HttpPut("{barcode}")]

    //    //many to many
    //    public void BookTrip(int customerID,int tripId)//fixa booktripDTO
    //    {
    //        BookingService.Instance.BookTrip(customerID,tripId)//booktrip.CustomerID,booktrip.TripId
    //    }
    //}
}

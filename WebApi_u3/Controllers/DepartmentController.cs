using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Service.DTO;

namespace WebApi_u3.Controllers
{
    [Route("departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public List<DepartmentMailDTO> ListMails()
        {
            var service = new DepartmentService();
            return service.GetMails();
        }
    }
}

using DAL;
using Microsoft.EntityFrameworkCore;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService
    {
        public List<DepartmentMailDTO> GetMails()
        {
            using var context = new StoreContext();
            var result = context.Departments
                .Include(x => x.Employee).ThenInclude(x => x.Mails)
                .Select(x => new DepartmentMailDTO
                {
                    DepartmentName = x.Name,
                    Emails = x.Employee.Mails.Select(m => m.Email).ToList()
                })
                .ToList();
            return result;
        }
    }
}

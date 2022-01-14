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
    public class EmployeeService
    {
        public CountEmployeeDTO GetInfo()
        {
            using (var context = new StoreContext())
            {
                var result = new CountEmployeeDTO();
                result.EmployeeCount = context.Employees.Count();
                var staff = context.Employees
                    .Include(e => e.Departments)
                    .ToList();
                foreach (var item in staff)
                {
                    result.EmployeeList.Add(new EmployeeListDTO
                    {
                        Name = item.Name,
                        ResponsiableForDepartment = context.Departments.Any(d => d.EmployeeRefId == item.ID)

                    });
                }
                return result;          
            }
        }
    }
}

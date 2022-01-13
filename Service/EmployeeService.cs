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
        //public List<EmployeeListDTO> GetInfo()
        //{
            //List<EmployeeListDTO> eDto = new();
            //using (var context = new StoreContext())
            //{

                //var count = context.Employees.Count();
                //var result = context.Employees

                //    .Include(e => e.Departments)
                //    .Select(e => new EmployeeListDTO
                //    {
                //        Name = e.Name,
                //        ResponsiableForDepartmen = true(Where e => e.Departments.EmployeeRefId == Employees.ID)
                //    })
                //    .ToList();
                //return result;

                //    foreach (var item in result)
                //    {
                //        //if (item.ID = e.Departments.EmployeeRefId) 
                //        //    {
                //        //    return false;
                //        //}
                //        //    else
                //        //{
                //            eDto.Add(new EmployeeListDTO { Name = item.Name });
                //        //}                      
                //    }
            //}

        //}

    }
}

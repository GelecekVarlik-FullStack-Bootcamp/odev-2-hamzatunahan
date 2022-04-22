using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class EmployeeManager<T, TDto> : GenericManager<Employee, DtoEmployee>, IEmployeeService
    {
        //IEmployeeRepository
        IEmployeeRepository employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IQueryable<DtoEmployee> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
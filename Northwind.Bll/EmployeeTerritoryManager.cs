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
    public class EmployeeTerritoryManager<T, TDto> : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        //IEmployeeTerritoryRepository
        IEmployeeTerritoryRepository employeeTerritoryRepository;

        public EmployeeTerritoryManager(IEmployeeTerritoryRepository employeeTerritoryRepository)
        {
            this.employeeTerritoryRepository = employeeTerritoryRepository;
        }

        public IQueryable<DtoEmployeeTerritory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
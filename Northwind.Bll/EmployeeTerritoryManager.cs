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
        public IQueryable<DtoEmployeeTerritory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
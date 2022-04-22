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
    public class TerritoryManager<T, TDto> : GenericManager<Territory, DtoTerritory>, ITerritoryService
    {
        //ITerritoryRepository
        ITerritoryRepository territoryRepository;

        public TerritoryManager(ITerritoryRepository territoryRepository)
        {
            this.territoryRepository = territoryRepository;
        }

        IQueryable<DtoTerritory> ITerritoryService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

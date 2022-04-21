﻿using Northwind.Entity.Dto;
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
        IQueryable<DtoTerritory> ITerritoryService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

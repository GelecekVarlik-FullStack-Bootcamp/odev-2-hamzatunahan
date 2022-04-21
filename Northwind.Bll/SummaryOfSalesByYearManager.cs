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
    public class SummaryOfSalesByYearManager<T, TDto> : GenericManager<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        //ISummaryOfSalesByYearRepository
        public IQueryable<DtoSummaryOfSalesByYear> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

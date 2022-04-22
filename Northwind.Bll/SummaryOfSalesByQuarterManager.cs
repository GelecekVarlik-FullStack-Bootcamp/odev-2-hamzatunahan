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
    public class SummaryOfSalesByQuarterManager<T, TDto> : GenericManager<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterService
    {
        //ISummaryOfSalesByQuarterRepository
        ISummaryOfSalesByQuarterRepository summaryOfSalesByQuarterRepository;

        public SummaryOfSalesByQuarterManager(ISummaryOfSalesByQuarterRepository summaryOfSalesByQuarterRepository)
        {
            this.summaryOfSalesByQuarterRepository = summaryOfSalesByQuarterRepository;
        }

        public IQueryable<DtoSummaryOfSalesByQuarter> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

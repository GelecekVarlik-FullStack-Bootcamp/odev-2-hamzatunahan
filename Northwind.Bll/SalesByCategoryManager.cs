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
    public class SalesByCategoryManager<T, TDto> : GenericManager<SalesByCategory, DtoSalesByCategory>, ISalesByCategoryService
    {
        //ISalesByCategoryRepository
        ISalesByCategoryRepository salesByCategoryRepository;

        public SalesByCategoryManager(ISalesByCategoryRepository salesByCategoryRepository)
        {
            this.salesByCategoryRepository = salesByCategoryRepository;
        }

        IQueryable<DtoSalesByCategory> ISalesByCategoryService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

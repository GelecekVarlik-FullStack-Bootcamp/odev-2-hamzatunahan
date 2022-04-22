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
    public class CurrentProductListManager<T, TDto> : GenericManager<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        //ICurrentProductListRepository
        ICurrentProductListRepository currentProductListRepository;

        public CurrentProductListManager(ICurrentProductListRepository currentProductListRepository)
        {
            this.currentProductListRepository = currentProductListRepository;
        }

        public IQueryable<DtoCurrentProductList> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
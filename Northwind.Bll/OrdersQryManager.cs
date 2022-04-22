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
    public class OrdersQryManager<T, TDto> : GenericManager<OrdersQry, DtoOrdersQry>, IOrdersQryService
    {
        //IOrdersQryRepository
        IOrdersQryRepository ordersQryRepository;

        public OrdersQryManager(IOrdersQryRepository ordersQryRepository)
        {
            this.ordersQryRepository = ordersQryRepository;
        }

        public IQueryable<DtoOrdersQry> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
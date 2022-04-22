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
    public class OrderDetailsExtendedManager<T, TDto> : GenericManager<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        //IOrderDetailsExtendedRepository
        IOrderDetailsExtendedRepository orderDetailsExtendedRepository;

        public OrderDetailsExtendedManager(IOrderDetailsExtendedRepository orderDetailsExtendedRepository)
        {
            this.orderDetailsExtendedRepository = orderDetailsExtendedRepository;
        }

        public IQueryable<DtoOrderDetailsExtended> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
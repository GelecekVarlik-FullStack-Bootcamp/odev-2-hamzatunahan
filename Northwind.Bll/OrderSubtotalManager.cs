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
    public class OrderSubtotalManager<T, TDto> : GenericManager<OrderSubtotal, DtoOrderSubtotal>, IOrderSubtotalService
    {
        //IOrderSubtotalRepository
        IOrderSubtotalRepository orderSubtotalRepository;

        public OrderSubtotalManager(IOrderSubtotalRepository orderSubtotalRepository)
        {
            this.orderSubtotalRepository = orderSubtotalRepository;
        }

        IQueryable<DtoOrderSubtotal> IOrderSubtotalService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
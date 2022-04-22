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
    public class OrderManager<T, TDto> : GenericManager<Order, DtoOrder>, IOrderService
    {
        //IOrderRepository
        IOrderRepository orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IQueryable<DtoOrder> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
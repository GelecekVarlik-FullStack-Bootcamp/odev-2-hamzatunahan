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
    public class QuarterlyOrderManager<T, TDto> : GenericManager<QuarterlyOrder, DtoQuarterlyOrder>, IQuarterlyOrderService
    {
        //IQuarterlyOrderRepository
        IQueryable<DtoQuarterlyOrder> IQuarterlyOrderService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

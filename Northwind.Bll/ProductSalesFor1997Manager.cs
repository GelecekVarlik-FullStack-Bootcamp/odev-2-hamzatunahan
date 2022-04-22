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
    public class ProductSalesFor1997Manager<T, TDto> : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        // IProductSalesFor1997Repository
        IProductSalesFor1997Repository productSalesFor1997Repository;

        public ProductSalesFor1997Manager(IProductSalesFor1997Repository productSalesFor1997Repository)
        {
            this.productSalesFor1997Repository = productSalesFor1997Repository;
        }

        public IQueryable<DtoProductSalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

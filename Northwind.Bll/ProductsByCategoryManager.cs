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
    public class ProductsByCategoryManager<T, TDto> : GenericManager<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        //IProductsByCategoryRepository
        IProductsByCategoryRepository productsByCategoryRepository;

        public ProductsByCategoryManager(IProductsByCategoryRepository productsByCategoryRepository)
        {
            this.productsByCategoryRepository = productsByCategoryRepository;
        }

        IQueryable<DtoProductsByCategory> IProductsByCategoryService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

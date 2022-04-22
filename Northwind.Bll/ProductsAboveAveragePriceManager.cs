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
    public class ProductsAboveAveragePriceManager<T, TDto> : GenericManager<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
        // IProductsAboveAveragePriceRepository
        IProductsAboveAveragePriceRepository productsAboveAveragePriceRepository;

        public ProductsAboveAveragePriceManager(IProductsAboveAveragePriceRepository productsAboveAveragePriceRepository)
        {
            this.productsAboveAveragePriceRepository = productsAboveAveragePriceRepository;
        }

        IQueryable<DtoProductsAboveAveragePrice> IProductsAboveAveragePriceService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

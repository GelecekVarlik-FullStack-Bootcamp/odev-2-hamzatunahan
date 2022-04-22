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
    public class CustomerAndSuppliersByCityManager<T, TDto> : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        //ICustomerAndSuppliersByCityRepository
        ICustomerAndSuppliersByCityRepository customerAndSuppliersByCityRepository;

        public CustomerAndSuppliersByCityManager(ICustomerAndSuppliersByCityRepository customerAndSuppliersByCityRepository)
        {
            this.customerAndSuppliersByCityRepository = customerAndSuppliersByCityRepository;
        }

        public IQueryable<DtoCustomerAndSuppliersByCity> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
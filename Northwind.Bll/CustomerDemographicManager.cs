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
    public class CustomerDemographicManager<T, TDto> : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        //ICustomerDemographicRepository
        ICustomerDemographicRepository customerDemographicRepository;

        public CustomerDemographicManager(ICustomerDemographicRepository customerDemographicRepository)
        {
            this.customerDemographicRepository = customerDemographicRepository;
        }

        public IQueryable<DtoCustomerDemographic> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
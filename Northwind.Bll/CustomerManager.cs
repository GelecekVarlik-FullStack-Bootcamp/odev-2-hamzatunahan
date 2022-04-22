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
    public class CustomerManager<T, TDto> : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        //ICustomerRepository
        ICustomerRepository customerRepository;

        public CustomerManager(ICustomerRepository customerRepository) //boyle mi kalacak? Genericmanagera constructor eklenince hata veriyor base:() mi lzm?
        {
            this.customerRepository = customerRepository;
        }

        public IQueryable<DtoCustomer> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
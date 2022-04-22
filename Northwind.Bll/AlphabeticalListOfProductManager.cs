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
    public class AlphabeticalListOfProductManager<T, TDto> : GenericManager<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>, IAlphabeticalListOfProductService
    {
        //IAlphabeticalListOfProductRepository
        IAlphabeticalListOfProductRepository alphabeticalListOfProductRepository;
        public AlphabeticalListOfProductManager(IAlphabeticalListOfProductRepository alphabeticalListOfProductRepository)
        {
            this.alphabeticalListOfProductRepository = alphabeticalListOfProductRepository;
        }

        public IQueryable<DtoAlphabeticalListOfProduct> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
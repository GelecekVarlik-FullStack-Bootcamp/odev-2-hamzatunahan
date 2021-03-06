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
    public class CategoryManager<T, TDto> : GenericManager<Category, DtoCategory>, ICategoryService
    {
        //ICategoryRepository
        ICategoryRepository categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IQueryable<DtoCategory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
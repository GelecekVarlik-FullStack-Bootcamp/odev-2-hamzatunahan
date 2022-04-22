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
    public class CategorySalesFor1997Manager<T, TDto> : GenericManager<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        //ICategorySalesFor1997Repository
        ICategorySalesFor1997Repository categorySalesFor1997Repository;

        public CategorySalesFor1997Manager(ICategorySalesFor1997Repository categorySalesFor1997Repository)
        {
            this.categorySalesFor1997Repository = categorySalesFor1997Repository;
        }

        public IQueryable<DtoCategorySalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
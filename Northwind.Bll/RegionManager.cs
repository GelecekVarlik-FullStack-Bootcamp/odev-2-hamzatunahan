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
    public class RegionManager<T, TDto> : GenericManager<Region, DtoRegion>, IRegionService
    {
        //IRegionRepository
        IRegionRepository regionRepository;

        public RegionManager(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        public IQueryable<DtoRegion> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

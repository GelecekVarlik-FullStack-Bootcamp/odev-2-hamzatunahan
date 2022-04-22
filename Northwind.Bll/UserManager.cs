﻿using Northwind.Dal.Abstract;
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
    public class UserManager<T, TDto> : GenericManager<User, DtoUser>, IUserService
    {
        //IUserRepository
        IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IQueryable<DtoUser> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

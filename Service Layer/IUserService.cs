﻿using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public interface IUserService <T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<T> Get(long id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(long id);
    }
}

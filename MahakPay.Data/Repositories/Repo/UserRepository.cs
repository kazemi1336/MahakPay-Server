using MahakPay.Data.Infrastructure;
using MahakPay.Data.Models;
using MahakPay.Data.DatabaseContext;
using MahakPay.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace MahakPay.Data.Repositories.Repo
{
    public class UserRepository :  Repository<User>, IUserRepository
    {
        private readonly DbContext _db;
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
            _db = (_db ?? (MahakDbContext)_db);
        }
    }
}

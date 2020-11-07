using MahakPay.Data.Repositories.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MahakPay.Data.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        UserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();
    }
}

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPortfolio.Server.Data.Models;
using MyPortfolio.Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Server.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public readonly IGenericRepository<Project>? _Project;


        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public IGenericRepository<Project> Project =>
            _Project ?? new GenericRepository<Project>(_context);

        /// <summary>
        /// Commits changes to the data source
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Asyncronously commit changes to the data source
        /// </summary>
        /// <returns></returns>
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Disposes of database connection
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

using EF101.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private EF101DBContext _context;

        public UnitOfWork(EF101DBContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public EF101DBContext context { get { return _context; } }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        EF101DBContext context { get; }
        void SaveChanges();
    }
}

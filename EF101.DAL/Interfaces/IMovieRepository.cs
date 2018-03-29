using EF101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL.Interfaces
{
    public interface IMovieRepository: IGenericRepository<Movie>
    {
        List<Movie> GetMoviesByGenre(string genre); 
    }
}

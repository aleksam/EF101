using EF101.DAL.Interfaces;
using EF101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(EF101DBContext context): base(context)
        {

        }
        public List<Movie> GetMoviesByGenre(string genre)
        {
            List<Movie> result = new List<Movie>();

            result = GetAll().Where(x => x.Genre == genre).ToList();

            return result;
        }
    }
}

using System;
using EF101.DAL.Interfaces;
using EF101.DAL.Repositories;
using EF101.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EF101.DAL.Tests
{
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void ShouldAddNewMovieToDatabase()
        {
            using (IUnitOfWork _unitOfWork = new UnitOfWork(new EF101DBContext()))
            {
                Movie newMovie = new Movie() {
                    ID=0,
                    Title = "Test Movie",
                    Genre = "Comedy",
                    Price = 10.00M,
                    ReleaseDate = DateTime.Now
                };

                var MoviesRepository = new GenericRepository<Movie>(_unitOfWork.context);

                MoviesRepository.Add(newMovie);

                _unitOfWork.SaveChanges();

                Assert.IsTrue(newMovie.ID > 0);
            }
        }
    }
}

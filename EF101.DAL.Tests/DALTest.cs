using System;
using System.Collections.Generic;
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
        public void ShouldPerformCRUD()
        {
            using (IUnitOfWork _unitOfWork = new UnitOfWork())
            {
                // (C)reate
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

                int newMovieId = newMovie.ID;

                // (R)ead
                var MoviesRepositorySpecific = new MovieRepository(_unitOfWork.context);

                List<Movie> listOfMovies = MoviesRepositorySpecific.GetMoviesByGenre("Comedy");

                // (U)pdate
                //newMovie.Genre = "Drama";

                //MoviesRepository.Edit(newMovie);

                //_unitOfWork.SaveChanges();

                //Movie updatedMovie = MoviesRepository.GetById(newMovieId);

                // (D)elete
                MoviesRepository.Delete(newMovie);

                _unitOfWork.SaveChanges();
                
                Movie testMovie = MoviesRepository.GetById(newMovieId);

                // Test
                Assert.IsTrue(newMovieId > 0);
                Assert.IsTrue(listOfMovies != null);
                Assert.IsTrue(listOfMovies.Count > 0);
                // Assert.IsTrue(updatedMovie.Genre == "Drama");
                Assert.IsTrue(testMovie == null);
            }
        }
    }
}

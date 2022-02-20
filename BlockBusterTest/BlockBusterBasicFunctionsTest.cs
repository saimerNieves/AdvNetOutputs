using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BlockBuster;
namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]

        public void testGetMovieByID() {

            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);


        }

        [Fact]

        public void GetAllMoviesTest() {

            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 49);
        }

        [Fact]

        public void GetAllCheckedOutMoviesTest()
        {

            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }




        [Fact]
        public void GetAllMoviesByGenreDescriptionTest()
        {

            var result = BlockBusterBasicFunctions.GetAllMoviesByGenreDescription("Drama");
            Assert.True(result.Count == 27);
        }

        [Fact]
        public void GetAllMoviesByDirectorLastNameTest()
        {

            var result = BlockBusterBasicFunctions.GetAllMoviesByDirectorLastName("Spielberg");
            Assert.True(result.Count == 5);
        }
    }
}

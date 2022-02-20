using BlockBuster.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace BlockBusterConsoleAppV2
{
    class OutputHelperClass
    {

        //Print information to the console
        public static void WriteToConsole(List<Movie> movies)
        {

            Console.WriteLine("List of Movies from the Database");

            foreach(var oneMovie in movies)
            {

                Console.WriteLine($"MovieID: {oneMovie.MovieId}           |   Title: {oneMovie.Title}                  |           Release Year:  {oneMovie.ReleaseYear}");

            }

        }

        //Print information to CSV
        public static void WriteToCSV(List<Movie> moviesList)
        {



            using (var writer = new StreamWriter(@"..\movies.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(moviesList);
            }
        }

        public static void dataResponseManager(string methodOfWritingData, List<Movie> dataToOut) {

            if (methodOfWritingData.ToLower().Equals("csv"))
            {

                OutputHelperClass.WriteToCSV(dataToOut);
            }
            else if (methodOfWritingData.ToLower().Equals("console"))
            {
                OutputHelperClass.WriteToConsole(dataToOut);

            }
        }
    }



}

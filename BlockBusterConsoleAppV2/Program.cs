using System;
using BlockBuster;
namespace BlockBusterConsoleAppV2
{
    class Program
    {

        private static string outputType; //variable to store output type string from user

        static void Main(string[] args)
        {

           
            Console.WriteLine("What is the ouput Type for getting all the movies ? Choose  csv  -    console     -   ");
            outputType = Console.ReadLine(); //asking user what outtput type they need and storing it into this variable


            //Since in this assignment we are just keeping the all movies method, the user has no other search methods but he will have options to the way they wish to save it
            var allOurMovies = BlockBusterBasicFunctions.GetAllMovies(); //getting all movies from the database

            //var outPutHelperInstance = new OutputHelperClass(); //Made methods static so we wouldn't need an instance

         

            switch (outputType) //check what the user typed in
            {
                case "csv":

                    OutputHelperClass.dataResponseManager(outputType, allOurMovies); //pass in method of saving and list of movies

                    Console.WriteLine("ALL Movies have been saved to your Computer , Please look for a file called Movies.csv in \\BlockBusterConsoleAppV2\\bin\\Debug- Press enter to continue");
                    Console.ReadLine(); // to read screen

                    break; //get out of switch statement

                case "console":

                    Console.WriteLine($"All Movies are being displayed in the console ");

                    OutputHelperClass.dataResponseManager(outputType, allOurMovies);  //pass in method of saving and list of movies
                    Console.ReadLine(); // to read screen
                    break;


                default: //go to this statement if is none of these
                    Console.WriteLine($"{outputType} is not a valid output option. ");
                    break;
            }


           // outPutHelperInstance.WriteToConsole(allOurMovies); //Write to Console
            //outPutHelperInstance.WriteToCSV(allOurMovies);   //Write to CSV

        }
    }
}

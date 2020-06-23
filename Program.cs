using System;
using System.Collections.Generic;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating a new movie.
            // Since I've passed in three arguments (string, string, int), it builds the object using the constructor with 3 arguments
            Movie myMovie = new Movie("Jurassic Park", "Steven Spielberg", 1993);

            // PrintDetails is a public method on the Movie class, so we can access it from Main
            // Note that the fields that were not assigned in the constructor are given default values 
            myMovie.PrintDetails();

            // Instantiating another movie object, again using the constructor with 3 parameters
            // Note the use of the 'var' keyword, instead of using the 'Movie' keyword, which is redundant
            var myOtherMovie = new Movie("Toy Story", "Unkown", 1995);

            // Print the details of myOtherMovie
            myOtherMovie.PrintDetails();

            // Instantiating a third movie object. 
            //This time we don't pass any parameters, so the compiler chooses the constructor that doesn't have any parameters
            var anotherMovie = new Movie();

            // Print the details of the third movie
            anotherMovie.PrintDetails();

        }

    }

    class Car {
        int year;

        char motorSize;

        string color;

        int numberOfDoors;

        string make;

        string model;

        bool isUsed;

    }



    class Movie {
        string title;
        string director;
        int runtimeInMinutes;
        int year;
        string genre;
        byte rating;

        // Constructor: Special method to build object
        // When you instantiate the movie with a 2 strings and an int, this constructor gets called
        // example: var someMovie = new Movie("Toy Story", "Unkown", 1995);
        public Movie(string theTitle, string theDirector, int theYear) {
            title = theTitle;
            director = theDirector;
            year = theYear;
            rating = 5;
        }

        // Another constructor. When you instantiate the movie without any parameters, this constructor is used to build the object
        // example: var myEmptyMovie = new Movie();
        public Movie() {
            title = "Default title";
            year = 1900;
        }

        // Class method. Since it is public, we can access it from the Main function
        // Since it is a class method (defined in the class), it hsa access to the data members of the class
        public void PrintDetails() {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Runtime: {runtimeInMinutes}");
            Console.WriteLine($"Rating: {rating}");
            Console.WriteLine("-------------");
        }

    }


}

using System;

namespace Unit3
{
    class Movie {
        
        public string Title { get; }

        string director;

        // public string GetTitle() {
        //     return title;
        // }

        public string GetDirector() {
            return director;
        }

        int runtimeInMinutes;
        int year;
        string genre;
        int totalRating;
        int numRatings;

        // Constructor: Special method to build object
        // When you instantiate the movie with a 2 strings and an int, this constructor gets called
        // example: var someMovie = new Movie("Toy Story", "Unkown", 1995);
        public Movie(string theTitle, string theDirector, int theYear) {
            Title = theTitle;
            director = theDirector;
            year = theYear;
            totalRating = 0;
            numRatings = 0;
        }

        // Another constructor. When you instantiate the movie without any parameters, this constructor is used to build the object
        // example: var myEmptyMovie = new Movie();
        public Movie() {
            Title = "Default title";
            year = 1900;
        }

        // Class method. Since it is public, we can access it from the Main function
        // Since it is a class method (defined in the class), it hsa access to the data members of the class
        public void PrintDetails() {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Runtime: {runtimeInMinutes}");
            //Console.WriteLine($"Rating: {rating}");
            Console.WriteLine($"Total Rating: {totalRating}");
            Console.WriteLine("-------------");
        }

        // Rate the movie with a value from 1-5
        public void Rate(int theRating) {
            // enforce that theRating is between and including 1-5
            if (theRating >= 1 && theRating <= 5) {
                totalRating += theRating;
                numRatings++;
            } else {
                Console.WriteLine($"Invalid rating {theRating}. Please try again.");
            }
        }

        // Get an average rating for the movie
        public double GetAverageRating() {
            if (numRatings > 0) {
                double doubleTotalRating = totalRating;
                double doubleNumRatings = numRatings;
                double averageRating = doubleTotalRating / doubleNumRatings;
                double roundedRating = Math.Round(averageRating, 2);
                return roundedRating;
            } else {
                return 0;
            }
        }

    }
}
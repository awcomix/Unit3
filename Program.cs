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
            //var myOtherMovie = new Movie("Toy Story", "Unkown", 1995);

            // Print the details of myOtherMovie
            //myOtherMovie.PrintDetails();

            Console.WriteLine(myMovie.Title); // OK
            //myMovie.Title = "incorrect title";
            Console.WriteLine(myMovie.GetDirector()); // OK
            //myMovie.director ="incorrect director"; // BAD!
            return;

            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Please enter a rating between 1 and 5 for the movie {myMovie.Title}");
                string userInput = Console.ReadLine();
                int intRating = Convert.ToInt32(userInput);
                myMovie.Rate(intRating);
            }

            double averageRating = myMovie.GetAverageRating();
            Console.WriteLine($"The average rating is: {averageRating}");
        }

    }
}


/*
var theHashtags = new List<string>(){ "hashtag1", "firstpost" };
// theHashtags.Add("hashtag1");
// theHashtags.Add("firstpost");

var myPost = new Post(
    "Hello, this is my first post!", 
    theHashtags, 
    "test_user");

myPost.PrintDetails();

*/
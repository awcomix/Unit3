using System;
using System.Collections.Generic;

namespace Unit3
{
    class Post {
        /*** Data members ***/
        int numViews;
        int numLikes;
        string text;
        string username;
        List<string> hashtags;
        DateTime dateCreated;

        // Constructor
        public Post(string theText, List<string> theHashtags, string theUsername) {
            text = theText;
            hashtags = theHashtags;
            username = theUsername;
            numLikes = 0;
            numViews = 0;
            dateCreated = DateTime.Now;
            //dateCreated = new DateTime(2020, 6, 23);
        }

        /*** Methods ***/
        // share the post
        // like the post
        // unlike the post
        // delete the post

        public void PrintDetails() {
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Number of Likes: {numLikes}");
            Console.WriteLine($"Date Created: {dateCreated}");
            Console.WriteLine($"Hashtags:");
            for (int i = 0; i < hashtags.Count; i++) {
                Console.WriteLine($"- #{hashtags[i]}");
            }
        }

    }
}
using Abstract_Classes.Models;
using System;
using System.ComponentModel.Design;

namespace Abstract_Classes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string input;
            string searching;
            Movie movie = new Movie();
            movie.Read();
            Show show = new Show();
            show.Read();
            Video video = new Video();
            video.Read();
            {
                Console.WriteLine("What kind of media do you want to see?");
                Console.WriteLine("Press 1 for movies, 2 for TV shows,  3 for home video, 4 to search or 5 to exit.");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Media movies = new Movie();
                    movies.Read();
                    movies.Display();
                }
                
                else if (input == "2")
                {
                    Media shows = new Show();
                    shows.Read();
                    shows.Display();
                }
                
                else if (input == "3")
                {
                    Media videos = new Video();
                    videos.Read();
                    videos.Display();

                }
                else if (input == "4")
                {
                  
                    Console.WriteLine("What would you like to search for?");
                    searching = Console.ReadLine();


                    Console.WriteLine(movie.Search(searching));
                    Console.WriteLine(show.Search(searching));
                    Console.WriteLine(video.Search(searching));


                }

                else
                {
                    Console.WriteLine("Please Choose 1, 2, 3, 4, or 5");
                }



            }
        }
    }
}

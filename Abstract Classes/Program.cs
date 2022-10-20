using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using Abstract_Classes.Models;

namespace Abstract_Classes
{
    internal class Program
    {
            
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("What kind of media do you want to see?");
                Console.WriteLine("Press 1 for movies, 2 for TV shows,  3 for home video, or 4 to exit.");
               
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine(" \n Displaying Movies: \n");

                        Media movies = new Movie();
                        movies.Read();
                        movies.Display();

                        break;
                    case "2":
                        Console.WriteLine("\n Displaying TV Shows: \n");
                        Media shows = new Show();
                        shows.Read();
                        shows.Display();
                        break;
                    case "3":
                        Console.WriteLine("\n Displaying Videos: \n");
                        Media videos = new Video();
                        videos.Read();
                        videos.Display();
                        break;

                    default:
                        Console.WriteLine("Please Choose 1, 2, 3 or 4");
                        break;
                }

            } while (input != "4");

        }
    }
}

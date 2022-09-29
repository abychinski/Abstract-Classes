using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using Abstract_Classes.Models;

namespace Abstract_Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What kind of media do you want to see?");
            Console.WriteLine("Press 1 for movies, 2 for TV shows, or 3 for home video.");
            var choice = Console.ReadLine();

            Media media = null;

            if (choice == "1")
            {
                media = new Movie();
               
               

            }
            else if (choice == "2")
            {
                media = new Show();
            }
            else if (choice == "3")
            {
                media = new Video();

            }

            media.Read();
            media.Display();
            
        }
    }
}

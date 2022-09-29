using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public class Movie : Media
    {
        string file = "movie.csv";
        private List<Movie> _movies;
        public string Genre;

        public Movie()
        {
            _movies = new List<Movie>();
            Read();

        }
        public override void Read()
        {
            var movie = new Movie();
            var sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                var movieInfo = line.Split(',');

                //var movie = new Movie();
                movie.Id = movieInfo[0];
                movie.Title = movieInfo[1];
                movie.Genre = movieInfo[2].Replace("|",",");


                _movies.Add(movie);
            }

        }
       

        public override void Display()
        {
            foreach (var movie in _movies)
            {
                Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Genre: {movie.Genre}");

            }
        }

    }
}

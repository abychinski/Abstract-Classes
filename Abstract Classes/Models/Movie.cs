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

        public List<Movie> movie;
       

        List<int> movieIds = new List<int>();
        List<string> movieTitles = new List<string>();
        List<string> movieGenres = new List<string>();
        public string Genres { get; set; }

        public override void Display()
        {
            for (int i = 0; i < movieIds.Count; i++)
            {

                Console.WriteLine($"Id: {movieIds[i]}");
                Console.WriteLine($"Title: {movieTitles[i]}");
                Console.WriteLine($"Genre(s): {movieGenres[i]}");
                Console.WriteLine();
            }
        }

        public override void Read()
        {

            StreamReader sr = new StreamReader("movies.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    string[] movieDetails = line.Split(',');
                    movieIds.Add(int.Parse(movieDetails[0]));
                    movieTitles.Add(movieDetails[1]);
                    movieGenres.Add(movieDetails[2].Replace("|", ", "));
                }
                else
                {

                    movieIds.Add(int.Parse(line.Substring(0, idx - 1)));
                    line = line.Substring(idx + 1);
                    idx = line.IndexOf('"');
                    movieTitles.Add(line.Substring(0, idx));
                    line = line.Substring(idx + 2);
                    movieGenres.Add(line.Replace("|", ", "));
                }
            }
            sr.Close();
        }
        public override Media Search(string searching)
        {
            return movie.FirstOrDefault(m => m.Title.Contains(searching, StringComparison.CurrentCultureIgnoreCase));
        }

    }
}

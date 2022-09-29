using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public class Show : Media
    {
        string file = "show.csv";
        private List<Show> _show;

        public string Episode;
        public string Season;
        public string Writers;

        public Show()
        {
            _show = new List<Show>();
            Read();
        }

        public override void Display()
        {
            foreach (var show in _show)
            {
                Console.WriteLine($"ID: {show.Id}, Title: {show.Title}, Season: {show.Season}, Episode: {show.Episode}, Writers: {show.Writers}");

            }


        }

        public override void Read()
        {
            var show = new Show();
            var sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                var showInfo = line.Split(',');

                //var movie = new Movie();
                show.Id = showInfo[0];
                show.Title = showInfo[1];
                show.Season = showInfo[2];
                show.Episode = showInfo[3];
                show.Writers = showInfo[4];


                _show.Add(show);
            }
        }
    }
}

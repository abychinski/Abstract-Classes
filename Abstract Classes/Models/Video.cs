using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public class Video : Media
    {
        string file = "video.csv";
        private List<Video> _video;
        // TODO need to add properties
        string Format;
        string Length;
        string Regions;

        public Video()
        {
            _video = new List<Video>();
            Read();
        }

        public override void Display()
        {
            foreach (var video in _video)
            {
                Console.WriteLine($"ID: {video.Id}, Title: {video.Title}, Format: {video.Format}, Length: {video.Length}, Region: {video.Regions}");

            }
        }

        public override void Read()
        {
            var video = new Video();
            var sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                var videoInfo = line.Split(',');

                //var movie = new Movie();
                video.Id = videoInfo[0];
                video.Title = videoInfo[1];
                video.Format = videoInfo[2];
                video.Length = videoInfo[3];
                video.Regions = videoInfo[3];


                _video.Add(video);
            }
        }
    }
}

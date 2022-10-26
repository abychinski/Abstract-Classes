using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public class Video : Media
    {
        private List<Video> video;

        public string Format { get; set; }
        public int Length { get; set; }

        public int[] Regions { get; set; }

        List<int> videoIds = new List<int>();
        List<string> videoTitles = new List<string>();
        List<string> videoFormats = new List<string>();
        List<int> videoLengths = new List<int>();
        List<string> videoRegions = new List<string>();



        public override void Display()
        {
            for (int i = 0; i < videoIds.Count; i++)
            {
                Console.WriteLine($"Id: {videoIds[i]}");
                Console.WriteLine($"Title: {videoTitles[i]}");
                Console.WriteLine($"Format(s): {videoFormats[i]}");
                Console.WriteLine($"Length: {videoLengths[i]}");
                Console.WriteLine($"Region(s): {videoRegions[i]}");
                Console.WriteLine();
            }
        }


        public override void Read()
        {
            StreamReader sr = new StreamReader("videos.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    string[] movieDetails = line.Split(',');
                    videoIds.Add(int.Parse(movieDetails[0]));
                    videoTitles.Add(movieDetails[1]);
                    videoFormats.Add(movieDetails[2].Replace("|", ", "));
                    videoLengths.Add(int.Parse(movieDetails[3]));
                    videoRegions.Add(movieDetails[4].Replace("|", ", "));
                }

            }
            sr.Close(); ;
        }
        public override Media Search(string searching)
        {
            Read();
            return video.FirstOrDefault(m => m.Title.Contains(searching, StringComparison.CurrentCultureIgnoreCase));


        }
    }
}
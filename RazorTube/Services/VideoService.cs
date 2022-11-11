using RazorTube.Data;
using System;
using System.Text;

namespace RazorTube.Services
{
    public class VideoService
    {
        public Video[] GetVideos()
        {
            var videos = new List<Video>();
            for (int i = 0; i < 20; i++)
            {
                double multiplier = Random.Shared.NextDouble();
                multiplier = multiplier * 1.5 + 0.5;
                //multiplier;// *= Random.Shared.NextDouble() / double.MaxValue * 9.0 + 1.0;
                int width = (int)(1600.0 * multiplier);
                int height = (int)(900.0 * multiplier);
                videos.Add(new Video
                {
                    Description = RandomString(100),
                    Title = RandomString(15),
                    ChannelName = RandomString(10),
                    ChannelIconUrl = "https://thispersondoesnotexist.com/image",
                    ThumbnailUrl = $"https://picsum.photos/{width}/{height}",
                });
            }
            return videos.ToArray();
        }
        static string RandomString(int length)
        {
            const string chars = "AaaaaBbCcDdEeeeeeeeeFfGgHhIiiiJjKkLlMmNnOooPpQqRrSsTtUuuVvWwXxYyZz ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Shared.Next(s.Length)]).ToArray());
        }
    }
}

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
            for (int i = 0; i < 30; i++)
            {
                int width = 1600 + Random.Shared.Next(-8, 8);
                int height = 900 + Random.Shared.Next(-5, 5);
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

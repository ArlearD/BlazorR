using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoR.Shared
{
    public class PostService
    {
        
        private readonly PostRepository repository = new PostRepository(dbContext);
        public Task<Post[]> GetPostsAsync(int page)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Post
            {
                Header = "NH",
                Id = 3,
                ImageURL = "SS",
                Sender = "ME",
                Text = "nyll"
            }).ToArray());
        }
    }

    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}

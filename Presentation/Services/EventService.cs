using Presentation.Models;

namespace Presentation.Services
{
    public class EventService : IEventService
    {
        public IEnumerable<EventModel> GetEvents()
        {
            return new List<EventModel>
            {
                new EventModel
                {
                    Id = 1,
                    Title = "React Workshop",
                    Date = new DateTime(2025, 6, 12, 15, 0, 0),
                    Location = "Stockholm",
                    Price = 200.0,
                    Description = "Learn to build fast and interactive web apps using React."
                },
                new EventModel
                {
                    Id = 2,
                    Title = "Tech Hackathon",
                    Date = new DateTime(2025, 7, 1, 13, 0, 0),
                    Location = "Göteborg",
                    Price = 250.0,
                    Description = "Collaborate with developers and designers to build prototypes in 24 hours."
                },
                new EventModel
                {
                    Id = 3,
                    Title = "Code Challenge",
                    Date = new DateTime(2025, 8, 21, 10, 0, 0),
                    Location = "Malmö",
                    Price = 200.0,
                    Description = "Sharpen your algorithm skills in this timed coding competition."
                },
                new EventModel
                {
                    Id = 4,
                    Title = "Tech Hackathon",
                    Date = new DateTime(2025, 9, 1, 13, 0, 0),
                    Location = "Göteborg",
                    Price = 250.0,
                    Description = "Collaborate with developers and designers to build prototypes in 24 hours."
                }
            };
        }
    }
}

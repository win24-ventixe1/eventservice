namespace Presentation.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public DateTime Date { get; set; }
        public string Location { get; set; } = "";
        public double Price { get; set; }
        public string Description { get; set; } = "";
    }
}

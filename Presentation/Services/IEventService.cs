using Presentation.Models;

namespace Presentation.Services
{
    public interface IEventService
    {
        IEnumerable<EventModel> GetEvents();
    }
}

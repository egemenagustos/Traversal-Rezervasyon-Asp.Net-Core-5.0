using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.DestinationCommands;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price= command.Price,
                Capacity = command.Capacity,
                DayNight= command.DayNight,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}

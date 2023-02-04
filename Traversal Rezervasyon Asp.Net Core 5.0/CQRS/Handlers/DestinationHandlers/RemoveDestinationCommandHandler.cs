﻿using DataAccessLayer.Concrete;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.DestinationCommands;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}

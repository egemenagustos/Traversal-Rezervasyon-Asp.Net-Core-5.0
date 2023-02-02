using DataAccessLayer.Concrete;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.DestinationQueries;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.DestinationResults;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIDQueryResult
            {
                Id = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
            };
        }
    }
}

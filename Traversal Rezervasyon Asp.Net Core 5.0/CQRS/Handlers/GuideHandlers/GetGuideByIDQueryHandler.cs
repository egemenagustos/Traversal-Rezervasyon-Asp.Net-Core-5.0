using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.GuideQueries;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.GuideResults;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name,
            };
        }
    }
}

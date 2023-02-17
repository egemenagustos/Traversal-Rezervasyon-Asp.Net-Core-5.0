using MediatR;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.GuideResults;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery : IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

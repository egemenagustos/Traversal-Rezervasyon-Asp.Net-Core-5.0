using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.GuideQueries;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.GuideResults;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Handlers.GuideHandlers
{

    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuideID,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}

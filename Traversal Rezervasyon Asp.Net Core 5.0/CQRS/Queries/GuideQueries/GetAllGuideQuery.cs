using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using System.Collections.Generic;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.GuideResults;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}

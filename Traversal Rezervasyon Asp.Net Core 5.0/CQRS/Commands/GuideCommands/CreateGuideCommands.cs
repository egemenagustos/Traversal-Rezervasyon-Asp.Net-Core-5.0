using MediatR;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommands : IRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.GuideCommands;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Results.GuideResults
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommands>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommands request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new EntityLayer.Concrete.Guide
            {
                Description = request.Description,
                Name = request.Name,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}

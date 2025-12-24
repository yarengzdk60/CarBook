using CarbookDomian.Entities;
using CarBoorApplication.Features.Mediator.Commands.ServicesCommand;
using CarBoorApplication.Interfaces;
using MediatR;

namespace CarBoorApplication.Features.Mediator.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler
        : IRequestHandler<RemoveServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public RemoveServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(
            RemoveServiceCommand request,
            CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value.ServiceID);
        }
    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.Mediator.Commands.PricingCommand;
using CarBoorApplication.Features.Mediator.Commands.ServicesCommand;
using CarBoorApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Handlers.ServicesHandler
{
    public class UpdateServicesCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public UpdateServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceID);
            values.Title = request.Title;
            values.Description = request.Description;
            values.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(values);
        }
    }
}

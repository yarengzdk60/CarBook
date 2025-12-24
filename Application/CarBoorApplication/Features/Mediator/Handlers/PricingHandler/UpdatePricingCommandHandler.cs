using CarbookDomian.Entities;
using CarBoorApplication.Features.Mediator.Commands.PricingCommand;
using CarBoorApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Handlers.PricingHandler
{
    public class UpdateServicesCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;
        public UpdateServicesCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.PricingID);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}

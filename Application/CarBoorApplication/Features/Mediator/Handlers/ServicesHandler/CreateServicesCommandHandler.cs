using CarbookDomian.Entities;
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
    public class CreateServicesCommandHandler :IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title
            });
        }
    }
}

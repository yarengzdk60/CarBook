using CarbookDomian.Entities;
using CarBoorApplication.Features.Mediator.Queries.PricingQueries;
using CarBoorApplication.Features.Mediator.Queries.ServicesQueries;
using CarBoorApplication.Features.Mediator.Result.PricingResult;
using CarBoorApplication.Features.Mediator.Result.ServiceResults;
using CarBoorApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Handlers.PricingHandler
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;
        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                Description = x.Description,
                IconUrl = x.IconUrl,
                Title = x.Title,
                ServiceID = x.ServiceID
            }).ToList();
        }
    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.Mediator.Queries.LocationQueries;
using CarBoorApplication.Features.Mediator.Result.LocationResult;
using CarBoorApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
      private readonly IRepository<Location> _repository;
        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                LocationID = x.LocationID,
                Name = x.Name,

            }).ToList();
        }

    }
}

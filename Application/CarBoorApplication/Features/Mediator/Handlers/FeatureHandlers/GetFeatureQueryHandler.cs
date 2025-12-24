using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.CarResult;
using CarBoorApplication.Features.Mediator.Quieris.FeatureQueries;
using CarBoorApplication.Features.Mediator.Result.FeatureResults;
using CarBoorApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository=repository;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {

            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResult
            {
                FeatureID=x.FeatureID,
                Name=x.Name



            }).ToList();
        }
    }
}

using CarbookDomian.Entities;
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
{                                                             //isteği yapaca yer ve döndürülecek sonuç
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {

        private readonly IRepository<Feature> _repository;
        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureID = values.FeatureID,
                Name = values.Name
            };
        }
    }
}

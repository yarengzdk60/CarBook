using CarBoorApplication.Features.Mediator.Result.LocationResult;
using MediatR;
using System.Collections.Generic;

namespace CarBoorApplication.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery
        : IRequest<List<GetLocationQueryResult>>
    {
    }
}

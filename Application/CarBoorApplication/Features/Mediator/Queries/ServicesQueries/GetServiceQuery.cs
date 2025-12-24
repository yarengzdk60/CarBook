using CarBoorApplication.Features.Mediator.Result.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Queries.ServicesQueries
{
    public class GetServiceQuery :IRequest<List<GetServiceQueryResult>>
    {
    }
}

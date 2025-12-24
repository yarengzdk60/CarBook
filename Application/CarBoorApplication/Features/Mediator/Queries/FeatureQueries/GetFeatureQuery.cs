using CarBoorApplication.Features.Mediator.Result.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Quieris.FeatureQueries
{
    public class GetFeatureQuery :IRequest<List<GetFeatureQueryResult >>
    {
    }
}

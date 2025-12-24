using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Result.FeatureResults
{
    public class GetFeatureQueryResult:IRequest<List<GetFeatureQueryResult>>
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }

    }
}

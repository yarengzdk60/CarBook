using CarBoorApplication.Features.Mediator.Result.PricingResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public GetPricingByIdQuery(int ıd)
        {
            Id=ıd;
        }

        public int Id { get; set; }
    }
}

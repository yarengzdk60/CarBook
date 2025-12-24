using CarBoorApplication.Features.Mediator.Result.FooterAddressResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.Mediator.Queries.FooterAdressQueries
{
    public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
    {
        public GetFooterAddressByIdQuery(int ıd)
        {
            Id=ıd;
        }

        public int Id { get; set; }
    }
}

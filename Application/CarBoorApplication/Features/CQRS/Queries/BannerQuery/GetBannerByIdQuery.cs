using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Queries.BannerQuery
{
    public class GetBannerByIdQuery
    {
        public GetBannerByIdQuery(int ıd)
        {
            Id=ıd;
        }

        public int Id { get; set; }
    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Queries.AboutQueries;
using CarBoorApplication.Features.CQRS.Queries.BannerQuery;
using CarBoorApplication.Features.CQRS.Result.AboutResult;
using CarBoorApplication.Features.CQRS.Result.BannerResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner>  _repositories;

        public GetBannerByIdQueryHandler(IRepository<Banner> repositories)
        {
            _repositories=repositories;
        }

        public async Task<GetBannerByIdQuaryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repositories.GetByIdAsync(query.Id);
            return new GetBannerByIdQuaryResult
            {
                BannerID = values.BannerID,
                Description = values.Description,
                Title=values.Title,
                VideoDescription=values.VideoDescription,
                VideoUrl=values.VideoUrl
            };
        }

    }
}
  
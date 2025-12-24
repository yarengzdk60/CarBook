using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.AboutResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public GetAboutQueryHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository=aboutRepository;
        }
    

    public  async Task<List<GetAboutQueryResult>>Handle()
        {
            var values = await _aboutRepository.GetAllAsync();
            return values.Select(x=> new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
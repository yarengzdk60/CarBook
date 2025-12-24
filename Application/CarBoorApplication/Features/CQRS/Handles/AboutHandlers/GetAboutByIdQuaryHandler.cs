using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Queries.AboutQueries;
using CarBoorApplication.Features.CQRS.Result.AboutResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.AboutHandlers
{
   
       public class GetAboutByIdQuaryHandler
    {

        private readonly IRepository<About> _aboutRepository;

        public GetAboutByIdQuaryHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository=aboutRepository;
        }

        public  async Task< GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _aboutRepository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Title = values.Title,
                Description = values.Description,
                ImageUrl = values.ImageUrl
            };
        }
    }
}

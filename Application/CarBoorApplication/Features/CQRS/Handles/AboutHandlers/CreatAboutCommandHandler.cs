using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.AboutCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.AboutHandlers
{
    public class CreatAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public CreatAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            await _aboutRepository.CreateAsync( new About 
            
            {
                Title = command.Title,
                Description = command.Description,
                ImageUrl = command.ImageUrl

            });
        }

    }
}

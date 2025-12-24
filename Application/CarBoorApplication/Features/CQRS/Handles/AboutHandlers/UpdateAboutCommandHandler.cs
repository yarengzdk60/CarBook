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
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public UpdateAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository=aboutRepository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var values = await _aboutRepository.GetByIdAsync(command.AboutID);
            values.Title = command.Title;
            values.Description = command.Description;
            values.ImageUrl = command.ImageUrl;
            await _aboutRepository.UpdateAsync(values);
        }
    }
}

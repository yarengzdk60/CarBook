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
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public RemoveAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository=aboutRepository;
        }


        public async Task Handle ( RemoveAboutCommand  command)
        {
           var values=await _aboutRepository.GetByIdAsync(command.Id);
            await _aboutRepository.RemoveAsync(values.AboutID);

        }
    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.AboutCommand;
using CarBoorApplication.Features.CQRS.Commend.BannerCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BannerHandlers
{
    public class RemoverBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;
        public RemoverBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(values.BannerID);

        }

       
    }
}

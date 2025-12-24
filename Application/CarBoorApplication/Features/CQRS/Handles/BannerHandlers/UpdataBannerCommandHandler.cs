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
    public class UpdataBannerCommandHandler
    {
        private readonly IRepository<Banner>  _repository;

        public UpdataBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository=repository;
        }

        public async Task Handle(UpdataBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoUrl=command.VideoUrl;
            values.VideoDescription=command.VideoDescription;
            await _repository.UpdateAsync(values);
        }
    }
}

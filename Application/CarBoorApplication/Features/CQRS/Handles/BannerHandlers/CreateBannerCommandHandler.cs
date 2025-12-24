using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.BannerCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _reporitory;

        public CreateBannerCommandHandler(IRepository<Banner> reporitory)
        {
            _reporitory=reporitory;
        }

        public async Task Handle(CreatBannerCommand command)
        {
            await _reporitory.CreateAsync(new Banner
            {
                Description=command.Description,
                Title=command.Title,
                VideoDescription=command.VideoDescription,
                VideoUrl=command.VideoUrl


            });

        }
    }
}

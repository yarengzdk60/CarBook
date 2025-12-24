using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.BannerCommand;
using CarBoorApplication.Features.CQRS.Commend.BrandCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _reporitory;

        public CreateBrandCommandHandler(IRepository<Brand> reporitory)
        {
            _reporitory=reporitory;
        }

        public async Task Handle(CreateBrandCommand command)
        {
            await _reporitory.CreateAsync(new Brand
            {
              
                Name=command.Name


            });

        }
    }
}

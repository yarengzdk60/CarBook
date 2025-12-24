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
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository=repository;
        }

        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandID);

            
            values.Name = command.Name;

            await _repository.UpdateAsync(values);

        }
    }
}

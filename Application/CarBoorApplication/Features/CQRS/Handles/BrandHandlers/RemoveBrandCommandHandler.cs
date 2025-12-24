using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.AboutCommand;
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
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;
        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(values.BrandID);

        }

       
    }
}

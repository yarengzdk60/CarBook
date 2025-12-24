using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.BannerCommand;
using CarBoorApplication.Features.CQRS.Commend.CarCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CarHandler
{
    public class UpdateCarCommandHandle
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandle(IRepository<Car> repository)
        {
            _repository=repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandID);

            values.Model = command.Model;
            values.Fuel= command.Fuel;
            values.Seat= command.Seat;
            values.Luggage= command.Luggage;
            values.Km= command.Km;
            values.Transmission= command.Transmission;
            values.CoverImageUrl= command.CoverImageUrl;
            values.BigImageUrl= command.BigImageUrl;
            values.BrandID= command.BrandID;


            await _repository.UpdateAsync(values);




        }
    }
}

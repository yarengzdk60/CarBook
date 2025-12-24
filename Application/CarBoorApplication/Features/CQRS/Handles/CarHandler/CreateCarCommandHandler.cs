using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Commend.CarCommand;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CarHandler
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository=repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
              
                Model=command.Model,
                Km=command.Km,
                Fuel=command.Fuel,
                Seat=command.Seat,
                Luggage=command.Luggage,
                Transmission=command.Transmission,
                CoverImageUrl=command.CoverImageUrl,
                BigImageUrl=command.BigImageUrl,
                BrandID=command.BrandID





            });

        }

    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Queries.CarQuery;
using CarBoorApplication.Features.CQRS.Result.CarResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CarHandler
{
    public class GetCarByIdQuaryHandlers
    {

        private readonly IRepository<Car> _repository;

        public GetCarByIdQuaryHandlers(IRepository<Car> repository)
        {
            _repository=repository;
        }

        public async Task<GetCarByIdQuaryResult> Handle(GetCarByIdQuary query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQuaryResult
            {

                CarID=values.CarID,
                BigImageUrl=values.BigImageUrl,
                CoverImageUrl=values.CoverImageUrl,
                BrandID=values.BrandID,
                Fuel=values.Fuel,
                Km=values.Km,
                Luggage=values.Luggage,
                Model=values.Model,
                Seat=values.Seat,
                Transmission=values.Transmission



            };

        }
    }
}

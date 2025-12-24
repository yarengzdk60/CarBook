using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.CarResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CarHandler
{
    public class GetCarQuaryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarQuaryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQuaryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQuaryResult
            {
                CarID = x.CarID,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                Fuel=x.Fuel,
                Seat=x.Seat,
                Luggage=x.Luggage,
                Km=x.Km,
                Model=x.Model,
                Transmission=x.Transmission,



            }).ToList();
        }
    }
}

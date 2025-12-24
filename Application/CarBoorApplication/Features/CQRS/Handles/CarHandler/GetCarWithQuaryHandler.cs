using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.CarResult;
using CarBoorApplication.Interfaces;
using CarBoorApplication.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.CarHandler
{
    public  class GetCarWithQuaryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithQuaryHandler(ICarRepository repository)
        {
            _repository=repository;
        }

        public  List<GetCarWithBrandQuaryResult> Handle()
        {
            var values =  _repository.GetCarListWithBrands();
            return values.Select(x => new GetCarWithBrandQuaryResult
            {
                BrandName=x.Brand.Name,
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

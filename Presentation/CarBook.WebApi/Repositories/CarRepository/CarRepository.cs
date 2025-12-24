using CarbookDomian.Entities;
using CarBookPersistence.Context;
using CarBoorApplication.Interfaces.CarInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CarBook.WebApiPersistance.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarbookContext _context;

        public CarRepository(CarbookContext context)
        {
            _context=context;
        }

        public List<Car> GetCarListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;

        }
    }
}

using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.BannerResult;
using CarBoorApplication.Features.CQRS.Result.BrandResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository; //banner tablosuna erişim sağlar

        public GetBrandQueryHandler(IRepository<Brand> repository) //DI ile bize bir kapı açar
        {
            _repository=repository;//repositoryi atar
        }
        public async Task<List<GetBrandQuaryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            //GetAllAsync veritabaına gider ve tüm banner kayıtlarını getirir liste olarak döndürür
            return values.Select(x => new GetBrandQuaryResult

            // x  banner tablosundaki her bir kaydı temsil eder bunu taşırken kapsuüleme eyaparak veirriz o yüzden dto için new
            // GetBannerQuaryResult nesnesi oluştururuz

            {
                //Sol taraf DTO daki property sağ da entity mapping yaptık yani
               
                BrandID = x.BrandID,
                Name = x.Name,

            }).ToList(); // Change this from ToListAsync() to ToList()

        }


    }
}
    


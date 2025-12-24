using CarbookDomian.Entities;
using CarBoorApplication.Features.CQRS.Result.BannerResult;
using CarBoorApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBoorApplication.Features.CQRS.Handles.BannerHandlers
{
    public class GetBannerQuaryHandlers
    {
      
        private readonly IRepository<Banner> _repository; //banner tablosuna erişim sağlar

        public GetBannerQuaryHandlers(IRepository<Banner> repository) //DI ile bize bir kapı açar
        {
            _repository=repository;//repositoryi atar
        }
        public async Task<List<GetBannerQuaryResult>> Handle()
        { 
            var values =  await _repository.GetAllAsync();
            //GetAllAsync veritabaına gider ve tüm banner kayıtlarını getirir liste olarak döndürür
            return values.Select( x => new GetBannerQuaryResult

            // x  banner tablosundaki her bir kaydı temsil eder bunu taşırken kapsuüleme eyaparak veirriz o yüzden dto için new
            // GetBannerQuaryResult nesnesi oluştururuz

            {
                //Sol taraf DTO daki property sağ da entity mapping yaptık yani
                BannerID = x.BannerID,

                Description= x.Description,
                Title= x.Title,
                VideoDescription= x.VideoDescription,
                VideoUrl= x.VideoUrl

            }).ToList(); // Change this from ToListAsync() to ToList()

        }


        }
    }


// Veriyi getir

//values = await _repository.GetAllAsync();
//Veriyi düzenle paketle
//values.Select(…)
// Cevabı Döndür.
//return ...

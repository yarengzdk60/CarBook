using CarBoorApplication.Features.CQRS.Commend.BrandCommand;
using CarBoorApplication.Features.CQRS.Handles.BrandHandlers;

using CarBoorApplication.Features.CQRS.Queries.BrandQuery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApiPersistance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQuaryHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly UpdateBrandCommandHandler _updataBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandController(CreateBrandCommandHandler createBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQuaryHandler, GetBrandQueryHandler getBrandQueryHandler, UpdateBrandCommandHandler updataBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _createBrandCommandHandler=createBrandCommandHandler;
            _getBrandByIdQuaryHandler=getBrandByIdQuaryHandler;
            _getBrandQueryHandler=getBrandQueryHandler;
            _updataBrandCommandHandler=updataBrandCommandHandler;
            _removeBrandCommandHandler=removeBrandCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var values = await _getBrandByIdQuaryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok("hAKKIMDA EKLENDİ");
        }

        [HttpDelete]

        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return Ok("HAKKIMDA SİLİNDİ");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updataBrandCommandHandler.Handle(command);
            return Ok("Hakkımda Bilgisi güncellendi");
        }
    }
}

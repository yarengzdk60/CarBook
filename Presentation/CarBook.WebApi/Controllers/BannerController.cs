using CarBoorApplication.Features.CQRS.Commend.BannerCommand;
using CarBoorApplication.Features.CQRS.Handles.BannerHandlers;
using CarBoorApplication.Features.CQRS.Queries.BannerQuery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApiPersistance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {

        private readonly GetBannerQuaryHandlers _getBannerQuaryHandlers;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly UpdataBannerCommandHandler _updataBannerCommandHandler;
        private readonly RemoverBannerCommandHandler _removerBannerCommandHandler;

        public BannerController(GetBannerQuaryHandlers getBannerQuaryHandlers, GetBannerByIdQueryHandler getBannerByIdQueryHandler, CreateBannerCommandHandler createBannerCommandHandler, UpdataBannerCommandHandler updataBannerCommandHandler, RemoverBannerCommandHandler removerBannerCommandHandler)
        {
            _getBannerQuaryHandlers=getBannerQuaryHandlers;
            _getBannerByIdQueryHandler=getBannerByIdQueryHandler;
            _createBannerCommandHandler=createBannerCommandHandler;
            _updataBannerCommandHandler=updataBannerCommandHandler;
            _removerBannerCommandHandler=removerBannerCommandHandler;
        }

        [HttpGet]

        public async Task<IActionResult> BannerList()
        {
            var values = await _getBannerQuaryHandlers.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> BannerGetById(int id)
        {
            var values = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(values);

        }



        [HttpPost]
        public async Task<IActionResult> CreatBanner(CreatBannerCommand command)


        {
            await _createBannerCommandHandler.Handle(command);
            return Ok("Banner created successfully");
        }

        [HttpDelete]

        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removerBannerCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Banner removed successfully");
        }

        [HttpPut]

        public async Task<IActionResult> UpdataBanner(UpdataBannerCommand command)
        {
            await _updataBannerCommandHandler.Handle(command);
            return Ok("Banner updated successfully");

        }
    }
}

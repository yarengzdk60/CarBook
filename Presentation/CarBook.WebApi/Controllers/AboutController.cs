using CarBoorApplication.Features.CQRS.Commend.AboutCommand;
using CarBoorApplication.Features.CQRS.Handles.AboutHandlers;
using CarBoorApplication.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApiPersistance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly CreatAboutCommandHandler _createAboutCommandHandler;
        private readonly GetAboutByIdQuaryHandler _getAboutByIdQuaryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;
        private readonly UpdateAboutCommandHandler _updataAboutCommandHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;

        public AboutController(CreatAboutCommandHandler createAboutCommandHandler, GetAboutByIdQuaryHandler getAboutByIdQuaryHandler, GetAboutQueryHandler getAboutQueryHandler, UpdateAboutCommandHandler updataAboutCommandHandler, RemoveAboutCommandHandler removeAboutCommandHandler)
        {
            _createAboutCommandHandler=createAboutCommandHandler;
            _getAboutByIdQuaryHandler=getAboutByIdQuaryHandler;
            _getAboutQueryHandler=getAboutQueryHandler;
            _updataAboutCommandHandler=updataAboutCommandHandler;
            _removeAboutCommandHandler=removeAboutCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var values = await _getAboutByIdQuaryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout( CreateAboutCommand command)
        {
            await _createAboutCommandHandler.Handle(command);
            return Ok("hAKKIMDA EKLENDİ");
        }

        [HttpDelete]

        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("HAKKIMDA SİLİNDİ");
        }

        [HttpPut]
        
        public async Task<IActionResult>UpdateAbout(UpdateAboutCommand command)
        {
            await _updataAboutCommandHandler.Handle(command);
            return Ok("Hakkımda Bilgisi güncellendi" );
        }
        
    }
}
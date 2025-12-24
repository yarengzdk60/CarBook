using CarBoorApplication.Features.CQRS.Commend.ContacCommand;
using CarBoorApplication.Features.CQRS.Handles.ContacHandlers;
using CarBoorApplication.Features.CQRS.Queries.ContacQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApiPersistance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContacController : ControllerBase
    {
        private readonly CreateContacCommandHandler _createContactCommandHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;

        public ContacController(CreateContacCommandHandler createContactCommandHandler, GetContactByIdQueryHandler getContactByIdQueryHandler, GetContactQueryHandler getContactQueryHandler, UpdateContactCommandHandler updateContactCommandHandler, RemoveContactCommandHandler removeContactCommandHandler)
        {
            _createContactCommandHandler=createContactCommandHandler;
            _getContactByIdQueryHandler=getContactByIdQueryHandler;
            _getContactQueryHandler=getContactQueryHandler;
            _updateContactCommandHandler=updateContactCommandHandler;
            _removeContactCommandHandler=removeContactCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _getContactQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));

            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _createContactCommandHandler.Handle(command);
            return Ok("İletişim Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveContact(int id)
        {
            await _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
            return Ok("İletişim Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);
            return Ok("İletişim Bilgisi Güncellendi");
        }

    }
}

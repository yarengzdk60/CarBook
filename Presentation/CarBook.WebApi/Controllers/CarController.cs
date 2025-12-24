using CarBoorApplication.Features.CQRS.Commend.CarCommand;
using CarBoorApplication.Features.CQRS.Handles.CarHandler;
using CarBoorApplication.Features.CQRS.Queries.CarQuery;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApiPersistance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly GetCarByIdQuaryHandlers _getCarByIdQuaryHandler;
        private readonly GetCarQuaryHandler _getCarQuaryHandler;
        private readonly UpdateCarCommandHandle _updateCarCommandHandle;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithQuaryHandler _getCarWithQuaryHandler;

        public CarController(
            CreateCarCommandHandler createCarCommandHandler,
            GetCarByIdQuaryHandlers getCarByIdQuaryHandler,
            GetCarQuaryHandler getCarQuaryHandler,
            UpdateCarCommandHandle updateCarCommandHandle,
            RemoveCarCommandHandler removeCarCommandHandler,
            GetCarWithQuaryHandler getCarWithQuaryHandler // 🔥 EKLENDİ
        )
        {
            _createCarCommandHandler = createCarCommandHandler;
            _getCarByIdQuaryHandler = getCarByIdQuaryHandler;
            _getCarQuaryHandler = getCarQuaryHandler;
            _updateCarCommandHandle = updateCarCommandHandle;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithQuaryHandler = getCarWithQuaryHandler; // 🔥 DÜZELTİLDİ
        }

        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _getCarQuaryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var values = await _getCarByIdQuaryHandler.Handle(new GetCarByIdQuary(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("ARABA EKLENDİ");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("ARABA SİLİNDİ");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandle.Handle(command);
            return Ok("ARABA GÜNCELLENDİ");
        }

        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var values = _getCarWithQuaryHandler.Handle();
            return Ok(values);
        }
    }
}

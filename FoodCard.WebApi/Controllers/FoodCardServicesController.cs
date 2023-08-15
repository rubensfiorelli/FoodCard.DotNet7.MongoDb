using FoodCard.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodCard.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodCardServicesController : ControllerBase
    {

        protected readonly IFoodCardServiceService _service;

        public FoodCardServicesController(IFoodCardServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var foodServices = await _service.GetAll();

            return Ok(foodServices);
        }

    }
}

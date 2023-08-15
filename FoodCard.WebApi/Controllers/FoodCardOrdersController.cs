using FoodCard.Application.InputModels;
using FoodCard.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace FoodCard.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodCardOrdersController : ControllerBase
    {
        protected readonly IFoodCardOrderService _service;

        public FoodCardOrdersController(IFoodCardOrderService service)
        {
            _service = service;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return NotFound();
            }

            var foodOrder = await _service.GetTracingCode(code);

            return Ok(foodOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFoodCardOrderInputModel model)
        {
            var code = await _service.Create(model);

            return CreatedAtAction(
                nameof(GetCode),
                new { code },
                model
                );
        }

    }
}

using FoodCard.Application.InputModels;
using FoodCard.Application.Services.Interfaces;
using FoodCard.Application.ViewModels;

namespace FoodCard.Application.Services
{
    public class FoodCardOrderService : IFoodCardOrderService
    {
        private readonly IFoodCardOrderService _repository;

        public FoodCardOrderService(IFoodCardOrderService repository)
        {
            _repository = repository;
        }

        public async Task<string> Create(AddFoodCardOrderInputModel model)
        {
            var foodCardOrder = model.ToEntity();

            try
            {
                var foodServices = model
                    .Services
                    .Select(s => s.ToEntity())
                    .ToList();

                foodCardOrder.SetupServices(foodServices);

                await _repository.Create(model);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return foodCardOrder.TrackingCode;

        }

        public async Task<FoodCardOrderViewModel> GetTracingCode(string trackingCode)
        {
            var foodOrder = await _repository.GetTracingCode(trackingCode);

            return foodOrder;
        }
    }
}

using FoodCard.Application.InputModels;
using FoodCard.Application.ViewModels;

namespace FoodCard.Application.Services.Interfaces
{
    public interface IFoodCardOrderService
    {
        Task<string> Create(AddFoodCardOrderInputModel model);
        Task<FoodCardOrderViewModel> GetTracingCode(string trackingCode);
    }
}

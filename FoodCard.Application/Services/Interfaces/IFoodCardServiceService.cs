using FoodCard.Application.ViewModels;

namespace FoodCard.Application.Services.Interfaces
{
    public interface IFoodCardServiceService
    {
        Task<List<FoodCardServiceViewModel>> GetAll();
    }
}

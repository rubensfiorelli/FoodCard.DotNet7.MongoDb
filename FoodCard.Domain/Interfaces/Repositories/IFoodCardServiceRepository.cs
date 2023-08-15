using FoodCard.Domain.Entities;

namespace FoodCard.Domain.Interfaces.Repositories
{
    public interface IFoodCardServiceRepository
    {
        Task<ICollection<FoodCardService>> GetAllAsync();
    }
}

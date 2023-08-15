using FoodCard.Domain.Entities;

namespace FoodCard.Domain.Interfaces.Repositories
{
    public interface IFoodCardOrderRepository
    {
        Task<FoodCardOrder> GetTrackinCodeAsync(string code);
        Task CreateAsync(FoodCardOrder foodCardOrder);
    }
}

using FoodCard.Domain.Entities;
using FoodCard.Domain.Interfaces.Repositories;
using MongoDB.Driver;

namespace FoodCard.Data.Repositories
{
    public class FoodCardServiceRepository : IFoodCardServiceRepository
    {
        private readonly IMongoCollection<FoodCardService> _collection;

        public FoodCardServiceRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<FoodCardService>("food-card-services");
        }

        public async Task<ICollection<FoodCardService>> GetAllAsync()
        {
            return await _collection.Find(t => true).ToListAsync();
        }
    }
}

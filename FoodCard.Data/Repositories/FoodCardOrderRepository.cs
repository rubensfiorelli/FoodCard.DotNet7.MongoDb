using FoodCard.Domain.Entities;
using FoodCard.Domain.Interfaces.Repositories;
using MongoDB.Driver;

namespace FoodCard.Data.Repositories
{
    public class FoodCardOrderRepository : IFoodCardOrderRepository
    {
        private readonly IMongoCollection<FoodCardOrder> _collection;

        public FoodCardOrderRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<FoodCardOrder>("food-card-orders");
        }

        public async Task CreateAsync(FoodCardOrder foodCardOrder)
        {
            await _collection.InsertOneAsync(foodCardOrder);
        }

        public async Task<FoodCardOrder> GetTrackinCodeAsync(string code)
        {
            return await _collection.Find(b => b.TrackingCode.Equals(code)).SingleOrDefaultAsync();
        }
    }
}

using FoodCard.Domain.Entities;
using MongoDB.Driver;

namespace FoodCard.Data.DbSeed
{
    public class DbSeed
    {
        private readonly IMongoCollection<FoodCardService> _collection;

        private List<FoodCardService> _FoodCardServices = new List<FoodCardService>()
        {
            new FoodCardService ("Cartao Refeicao", 1600, 5.5m),
            new FoodCardService ("Cartao Refeicao", 1230, 5.5m),
            new FoodCardService ("Cartao Refeicao", 1100, 5.5m)

        };

        public DbSeed(IMongoDatabase database)
        {
            _collection = database.GetCollection<FoodCardService>("food-card-services");
        }

        public void Populate()
        {
            if (_collection.CountDocuments(c => true) == 0)
                _collection.InsertMany(_FoodCardServices);
        }
    }
}

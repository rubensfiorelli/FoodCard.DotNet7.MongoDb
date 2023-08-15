using FoodCard.Domain.Entities.Comman;

namespace FoodCard.Domain.Entities
{
    public sealed class FoodCardOrderService : BaseEntity
    {
        public FoodCardOrderService(string title, decimal price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}

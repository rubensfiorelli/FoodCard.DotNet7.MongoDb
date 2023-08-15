using FoodCard.Domain.Entities.Comman;

namespace FoodCard.Domain.Entities
{
    public sealed class FoodCardService : BaseEntity
    {
        public FoodCardService(string title, decimal benfitValue, decimal fixedPriceCard) : base()
        {
            Title = title;
            BenfitValue = benfitValue;
            FixedPriceCard = fixedPriceCard;
        }

        public string Title { get; private set; }
        public decimal BenfitValue { get; private set; }
        public decimal FixedPriceCard { get; private set; }
    }
}

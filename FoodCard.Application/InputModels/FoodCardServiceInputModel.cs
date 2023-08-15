using FoodCard.Domain.Entities;

namespace FoodCard.Application.InputModels
{
    public class FoodCardServiceInputModel
    {
        public string Title { get; set; }
        public decimal BenfitValue { get; set; }
        public decimal FixedPriceCard { get; set; }

        public FoodCardService ToEntity()
            => new FoodCardService(Title, BenfitValue, FixedPriceCard);

    }
}
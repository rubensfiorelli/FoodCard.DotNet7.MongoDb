using FoodCard.Domain.Entities;

namespace FoodCard.Application.InputModels
{
    public class AddFoodCardOrderInputModel
    {
        public string Description { get; set; }
        public decimal ServiceFee { get; set; }
        public DeliveryAddressInputModel DeliveryAddress { get; set; }
        public List<FoodCardServiceInputModel> Services { get; set; }

        public FoodCardOrder ToEntity()
            => new FoodCardOrder(
                Description,
                ServiceFee,
                DeliveryAddress.ToValueObject()
                );


    }
}
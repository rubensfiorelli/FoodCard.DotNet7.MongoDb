using FoodCard.Domain.Entities;

namespace FoodCard.Application.ViewModels
{
    public class FoodCardOrderViewModel
    {
        public FoodCardOrderViewModel(string trackingCode,
                                      string description,
                                      DateTime postedAt,
                                      decimal serviceFee,
                                      string fullAddress)
        {
            TrackingCode = trackingCode;
            Description = description;
            PostedAt = postedAt;
            ServiceFee = serviceFee;
            FullAddress = fullAddress;
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public decimal ServiceFee { get; private set; }
        public string FullAddress { get; private set; }


        public static FoodCardOrderViewModel FromEntity(FoodCardOrder foodCardOrder)
        {
            var address = foodCardOrder.DeliveryAddress;

            return new FoodCardOrderViewModel(
                foodCardOrder.TrackingCode,
                foodCardOrder.Description,
                foodCardOrder.PostedAt,
                foodCardOrder.ServiceFee,
                $"{address.EmployeeNumber}, {address.FirstName}, {address.LastName}, {address.ZipCode}, " +
                $"{address.Street}, {address.Number}, {address.Complement}, {address.City}, {address.State}");
        }

    }
}

using FoodCard.Domain.Entities.Comman;
using FoodCard.Domain.Entities.ValueObject;
using FoodCard.Domain.Enums;

namespace FoodCard.Domain.Entities
{
    public sealed class FoodCardOrder : BaseEntity
    {
        public FoodCardOrder(string description,
                             decimal serviceFee,
                             DeliveryAddress deliveryAddress) : base()
        {
            TrackingCode = GenerateTrackingCode();
            Description = description;
            PostedAt = DateTime.UtcNow.AddDays(1);
            ServiceFee = 6 / 100;
            DeliveryAddress = deliveryAddress;

            Status = EfoodCardStatus.Started;
            Services = new List<FoodCardOrderService>();
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public decimal ServiceFee { get; private set; }
        public DeliveryAddress DeliveryAddress { get; private set; }
        public EfoodCardStatus Status { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<FoodCardOrderService> Services { get; private set; }


        public void SetupServices(List<FoodCardService> services)
        {
            foreach (var service in services)
            {
                var servicePrice = service.FixedPriceCard + service.BenfitValue + (ServiceFee * service.BenfitValue);
                TotalPrice += servicePrice;
                Services.Add(new FoodCardOrderService(service.Title, servicePrice));
            }
        }

        private static string GenerateTrackingCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            var code = new char[10];
            var random = new Random();

            for (var i = 0; i < 5; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 5; i < 10; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new string(code);
        }
    }
}

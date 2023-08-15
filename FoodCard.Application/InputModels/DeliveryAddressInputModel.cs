using FoodCard.Domain.Entities.ValueObject;

namespace FoodCard.Application.InputModels
{
    public class DeliveryAddressInputModel
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public DeliveryAddress ToValueObject()
            => new DeliveryAddress(EmployeeNumber, FirstName, LastName, ZipCode, Street, Number, Complement, City, State);
    }
}
namespace FoodCard.Domain.Entities.ValueObject
{
    public record DeliveryAddress
    {
        public DeliveryAddress(int employeeNumber,
                               string firstName,
                               string lastName,
                               string zipCode,
                               string street,
                               int number,
                               string complement,
                               string city,
                               string state)
        {
            EmployeeNumber = employeeNumber;
            FirstName = firstName;
            LastName = lastName;
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
        }

        public int EmployeeNumber { get; private init; }
        public string FirstName { get; private init; }
        public string LastName { get; private init; }
        public string ZipCode { get; private init; }
        public string Street { get; private init; }
        public int Number { get; private init; }
        public string Complement { get; private init; }
        public string City { get; private init; }
        public string State { get; private init; }

    }
}

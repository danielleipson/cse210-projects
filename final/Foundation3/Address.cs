namespace Foundation3
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }

        public Address(string street, string city, string stateProvince, string country)
        {
            Street = street;
            City = city;
            StateProvince = stateProvince;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {StateProvince}, {Country}";
        }
    }
}
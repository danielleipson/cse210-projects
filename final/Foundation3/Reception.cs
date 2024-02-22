namespace Foundation3
{
    class Reception : Event
    {
        public string RsvpEmail { get; set; }

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
        {
            RsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
        }
    }
}
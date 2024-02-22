namespace Foundation3
{
    class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public Address Address { get; set; }

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
        }

    
        public virtual string GetFullDetails()
        {
        return GetStandardDetails(); 
        }

    
        public virtual string GetShortDescription()
        {
            return $"Type: Event\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}

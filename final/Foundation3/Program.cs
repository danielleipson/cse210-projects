using System;
namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var lecture = new Lecture("Introduction to Italian Style Painting", "Learn the Italian painting style", new DateTime(2024, 2, 20), "10:00 AM", new Address("103 Headquarters Loop", "Moose", "WY", "USA"), "Erica Braun", 25);
            var reception = new Reception("Networking Mixer", "Connect with leading artist professionals", new DateTime(2024, 2, 21), "6:00 PM", new Address("Paradise Park Trail", "Rhododendron", "OR", "USA"), "info@connections.com");
            var outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy watercolor painting and food", new DateTime(2024, 2, 22), "12:00 PM", new Address("1002 Snow Canyon Drive", "Ivins", "UT", "USA"), "Sunny");

       
            Console.WriteLine("Lecture Details:");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine("-------------------");

            Console.WriteLine("Reception Details:");
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine("-------------------");

            Console.WriteLine("Outdoor Gathering Details:");
            Console.WriteLine(outdoorGathering.GetFullDetails());
        }
    }
}
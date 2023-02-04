namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }

        public string DayNight { get; set; }

        public double Price { get; set; }

        public int Capacity { get; set; }

    }
}

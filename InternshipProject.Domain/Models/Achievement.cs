namespace Internship_Project
{
    public class Achievement(SportsEnum sport, User athlete, string eventType, string dateOfEvent, ushort placeFinished)
    {
        public DateTime Created { get; set; } = DateTime.Parse(dateOfEvent);
        public SportsEnum Sport { get; set; } = sport; 
        public User Athlete { get; set; } = athlete;
        public string EventType { get; set; } = eventType;
        public ushort? Place { get; set; } = placeFinished;
    }
}
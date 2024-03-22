namespace Internship_Project
{
    public class Achievement(SportsEnum sport, User athlete, string eventType, string dateOfEvent, int place)
    {
        public DateTime Created = DateTime.Parse(dateOfEvent);
        public SportsEnum Sport = sport; 
        public User Athlete = athlete;
        public string EventType = eventType;
        public int? Place = place;
    }
}

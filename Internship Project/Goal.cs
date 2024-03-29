﻿namespace Internship_Project
{
    public class Goal(string date, EventsEnum eventType, SportsEnum sport, decimal amount)
    {
        public DateTime Date { get; set; } = DateTime.Parse(date);
        public EventsEnum EventType { get; set; } = eventType;
        public SportsEnum Sport { get; set; } = sport;
        public decimal AmountNeeded { get; set; } = amount;
    }
}
// Goal class - date, type of the event (Race, Self-organized, Training etc.), sport, Competitor profile etc.
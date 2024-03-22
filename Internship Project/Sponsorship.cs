namespace Internship_Project
{

    public enum SponsorshipLevel
    {
        Monthly, Annual, SinglePayment // FundRaiser and Donation might be the same?
    }

    public class Sponsorship(SponsorshipLevel level, User sponsor, User athlete, float amount)
    {
        public DateTime Created = DateTime.Now;
        public SponsorshipLevel Level = level;
        public User Sponsor = sponsor;
        public User Athlete = athlete;
        private float _amount = amount;
    }
}

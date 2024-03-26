namespace Internship_Project
{
    public interface ISponsor
    {
        public List<User> SponsoredAthletes { get; set; }
        public Task BecomeSponsor();
        public Task CancelSponsorship();
    }
}

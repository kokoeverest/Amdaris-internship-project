namespace Internship_Project
{
    public class SponsorCompany(
         string name,
         string email,
         string password,
         string country,
         string iban
        ) : User( name, email, password, country ), ISponsor
    {
        public string IBAN { get; set; } = iban;
        public List<User> SponsoredAthletes { get; set; } = [];
        public Task BecomeSponsor();
        public Task CancelSponsorship();
    }
}

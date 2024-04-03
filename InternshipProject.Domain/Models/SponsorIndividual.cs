namespace Internship_Project
{
    public class SponsorIndividual(
     string name,
     string email,
     string password,
     string country,
     string birthDate
        ) : User(name, email, password, country), ISponsor
    {
        private DateTime _birthDate = DateTime.Parse(birthDate);
        public DateTime BirthDate => _birthDate;
        public int Age => (int)(DateTime.Now.Subtract(BirthDate).TotalDays / 365);
        public List<User> SponsoredAthletes { get; set; } = [];
        public Task BecomeSponsor() { }
        public Task CancelSponsorship() { }
    }
}

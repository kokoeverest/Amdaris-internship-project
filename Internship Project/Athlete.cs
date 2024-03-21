namespace Internship_Project
{
    public class Athlete(
        string name,
        string lastName,
        string email,
        string password,
        string country,
        string phone,
        string birthDate,
        string sport
        ) : User(name,
        email,
        password,
        country
        )
    {
        private string _phone = phone;
        private DateTime _birthDate = DateTime.Parse(birthDate);
        public string LastName = lastName;
        public string Sport = sport;
        private List<User> _sponsors = [];

        public string PhoneNumber => _phone;
        public DateTime BirthDate => _birthDate;
        public int Age => (int) (DateTime.Now.Subtract(BirthDate).TotalDays / 365);
        public List<User> Sponsors => _sponsors;
     
        
    }
}

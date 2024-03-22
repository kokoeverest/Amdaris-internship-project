namespace Internship_Project
{
    public class SponsorIndividual(
     string name,
     string email,
     string password,
     string country
        ) : User( name, email, password, country ), ISponsor
    {
    }
}

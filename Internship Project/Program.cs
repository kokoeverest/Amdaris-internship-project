using Internship_Project;
var input = delegate (string s)
{
    Console.WriteLine(s);
    return Console.ReadLine();
};
//var name = input("First name: ");
//var email = input("Email: ");
//var pass = input("Password: ");
//var country = input("Country: ");
//var lastName = input("Last name: ");
//var phone = input("Phone: ");
//var birthDay = input("Date of birth: dd/mm/yyyy");
//var sport = input("Sport: ");

//Athlete currentAthlete = new(
//    name,
//    lastName,
//    email,
//    pass,
//    country,
//    phone,
//    birthDay,
//    sport
//    );

Athlete currentAthlete = new("Petar", "Petrov", "mail@mail.mail", "", "Bulgaria", "0812849282", "20/3/1999", "football");
//SponsorIndividual sponsor = new (name, email, pass, country);
//await sponsor.Register();
await currentAthlete.Register();
//var sports = GetAllSports();

//foreach (var sport in sports)
//{
//    Console.WriteLine(sport);
//}

//SportsEnum[] GetAllSports()
//{
//    var sports = (SportsEnum[])SportsEnum.GetValues(typeof(SportsEnum));
//    return sports;
//}


// Sponsorship class, enums for monthly, annual, single payment
// Achievement class
// Bank account class
// Database class - for storage of all info (sample schema of the db)
// implementation for searching for athletes and sponsors with filtering
// search athletes by name (alphabetically), age (ascending), country, sport, achievements, urgent needs for sponsorship (goal in the near future)
// search sponsors by name, country, amount of athletes or money provided
// subscription ...

Console.WriteLine();
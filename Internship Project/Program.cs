using Internship_Project;
using System.Threading.Channels;
var input = delegate (string s)
{
    Console.WriteLine(s);
    return Console.ReadLine();
};

//Athlete currentAthlete = new(
//    input("First name: "),
//    input("Last name: "),
//    input("Email: "),
//    input("Password: "),
//    input("Country: "),
//    input("Phone: "),
//    input("Date of birth: dd/mm/yyyy"),
//    input("Sport: ")
//    );
Athlete currentAthlete = new("Petar", "Petrov", "mail@mail.mail", "", "Bulgaria", "0812849282", "20/3/1999", "football");
Console.WriteLine(currentAthlete.Age);
Console.WriteLine(currentAthlete.Sponsors);
await currentAthlete.Register();

var stop = 0;

// Sponsorship class, enums for monthly, annual, single payment
// Achievement class
// Bank account class
// Database class - for storage of all info (sample schema of the db)
    // implementation for searching for athletes and sponsors with filtering
    // search athletes by name (alphabetically), age (ascending), country, sport, achievements, urgent needs for sponsorship (goal in the near future)
    // search sponsors by name, country, amount of athletes or money provided
// subscription ...
using Internship_Project;
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

// donations as objects, to be implemented in a class Donation
// subscription ...
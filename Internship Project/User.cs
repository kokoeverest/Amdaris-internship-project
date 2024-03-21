using Internship_Project.Logs;

namespace Internship_Project
{
    public abstract class User(
        string name,
        string email,
        string password,
        string country
        ) : IUser
    {
        public int? Id { get; set; } = null;
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public string Password { private get; set; } = password;
        public string Country { get; set; } = country;
        public string Phone { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public string PictureOrLogo { get; set; } = string.Empty;

        public async Task Register()
        {
            Logger currentLog = new("Register", true);
            try
            {
                await currentLog.LogMessage(currentLog);
                Console.WriteLine($"{Name} registered successfully!");

            }
            catch (InvalidOperationException)
            {
                currentLog.Success = false;
                await currentLog.LogMessage(currentLog);
                await Console.Out.WriteLineAsync($"{Name} could not be registered!");
            }
        }
        public void Login() { }
        public void Logout() { }
        public void ResetPassword() { }
        public void EditProfile() { }
    }
}

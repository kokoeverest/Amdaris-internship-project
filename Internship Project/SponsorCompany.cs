﻿namespace Internship_Project
{
    public class SponsorCompany(
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

        public void Register(string email, string password) { }
        public void Login() { }
        public void Logout() { }
        public void ResetPassword() { }
        public void EditProfile() { }
    }
}
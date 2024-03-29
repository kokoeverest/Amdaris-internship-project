﻿namespace Internship_Project
{
    public interface IUser
    {
        public int? Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { set; }
        public string Country { get; }
        public string Phone { get; set; }
        public DateTime Created { get; set; } 
        public string PictureOrLogo { get; set; }
        public string Website {  get; set; }
        public string FaceBookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string StravaLink { get; set; }
        public List<BlogPost> Posts { get; set; }
        public Task Register();
        public Task Login();
        public Task Logout();
        public Task ResetPassword();
        public Task EditProfile();
    }
}

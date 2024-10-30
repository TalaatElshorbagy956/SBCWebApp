namespace MCISBCWebApp.Models
{
    public class LoginModel
    {
        public LoginModel(string username=null, string password=null)
        {
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
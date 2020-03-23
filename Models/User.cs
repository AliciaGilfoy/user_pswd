namespace user_pswd.Models
{
  class User
  {
    public string Username { get; set; }
    private string _password { get; set; }

    public bool ValidatePassword(string input)
    {
      return (_password == input);
    }


    public User(string username, string password)
    {
      Username = username;
      _password = password;
    }
  }
}
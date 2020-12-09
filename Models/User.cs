namespace loginchallenge.Models
{
  public class User
  {
    public User(string name, string password)
    {
      Name = name;
      Password = password;
    }

    public bool ValidatePassword(string input)
    {
      //   if (input == Password)
      //   {
      //     return true;
      //   }
      //   return false;
      return input == Password;
    }

    public string Name { get; set; }
    public string Password { get; set; }


  }
}
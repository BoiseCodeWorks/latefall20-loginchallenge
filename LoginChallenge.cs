using System;
using System.Collections.Generic;
using loginchallenge.Models;

namespace loginchallenge
{
  public class LoginChallenge
  {


    public Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
    public void Login()
    {
      Console.WriteLine("Please log in to continue \nUsername:");
      string username = Console.ReadLine();
      Console.WriteLine("Password:");
      string password = Console.ReadLine();
      if (Users.ContainsKey(username.ToLower()) && Users[username.ToLower()].ValidatePassword(password))
      {
        System.Console.WriteLine("Welcome to the mainframe");
      }
      else
      {
        System.Console.WriteLine("Authorities are on their way");
      }

    }

    public void Register(User newUser)
    {
      Users.Add(newUser.Name.ToLower(), newUser);
    }

    public LoginChallenge()
    {
      //ALWAYS INSTANTIATE ANY COLLECTION TYPE
      //   Users = new Dictionary<string, User>();
      User tim = new User("Tim", "password123");
      User miles = new User("Miles", "chalupa");
      User tom = new User("Tom", "Password123");

      Register(tim);
      Register(miles);
      Register(tom);
    }

  }
}
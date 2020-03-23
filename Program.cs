using System;
using System.Collections.Generic;
using user_pswd.Models;

namespace user_pswd
{
  class Program
  {
    static void Main(string[] args)
    {
      User alicia = new User("alicia", "ILoveCoding");
      User josh = new User("josh", "password");
      User josie = new User("josie", "kittycat");
      User alton = new User("alton", "NinjaBoy");

      Dictionary<string, User> users = new Dictionary<string, User>();
      users.Add(alicia.Username.ToLower(), alicia);
      users.Add(josh.Username.ToLower(), josh);
      users.Add(josie.Username.ToLower(), josie);
      users.Add(alton.Username.ToLower(), alton);

      System.Console.WriteLine("Hello!");
      System.Console.Write("Username: ");
      string nameInput = Console.ReadLine().ToLower();
      Console.Write("Password: ");
      string passwordInput = Console.ReadLine();

      if (users.ContainsKey(nameInput) && users[nameInput].ValidatePassword(passwordInput))
      {
        System.Console.WriteLine("Successfully logged in!");
      }
      else
      {
        System.Console.WriteLine("Incorrect password!");
      }
    }
  }
}

using System;
using NEWKESCHA.Classes;

namespace NEWKESCHA
{
  class Program
  {
    static void Main()
    {
      Animal kescha = new Animal(animalName: "Kescha", animalAge: 3);

      Console.Write("Enter your name: ");
      string userName=Console.ReadLine();

      kescha.Greet(userName);

      string password="";
      do
      {
        Console.Write("Enter password: ");
        password=Console.ReadLine();
      }while(password!="123");

      Console.Write("Enter your age: ");
      string ageAsString = Console.ReadLine();

      Console.WriteLine("Converting...");

      int userAge = Convert.ToInt32(ageAsString);
      Console.WriteLine($"Succesfully converted! {userAge}");

      kescha.CalculateAgeDifferenceWithNoReturn(userAge);
      kescha.PrintAgeDifference();
      kescha.CompareAges(userAge);
      kescha.TellAboutFriends(userName, userAge);
    }
  }
}

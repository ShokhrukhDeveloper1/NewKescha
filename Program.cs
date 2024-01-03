using System;
using NEWKESCHA.Classes;

namespace NEWKESCHA
{
  class Program
  {
    static void Main()
    {
      try
      {
        Animal kescha = new Bird(animalName: "Kescha", animalAge: 3);
        Animal kasee = new Pet(animalName: "Kasee", animalAge: 5);

        Console.WriteLine("Kescha was created: "+kescha.CreatedDate);
        Console.WriteLine("Kasee was created: "+kasee.CreatedDate);

        Console.Write("Enter your name: ");
        string userName=Console.ReadLine();

        Console.WriteLine("Kescha says:");
        kescha.Greet(userName);
        Console.WriteLine("Kasee says:");
        kasee.Greet(userName);

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
      catch(FormatException formatException)
      {
        Console.WriteLine($"Error was thrown. Message: {formatException.Message}");
      }
      finally
      {
        Console.WriteLine("Program ended.");
      }

    }
  }
}

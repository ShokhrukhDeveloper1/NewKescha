namespace NEWKESCHA.Classes
{
  public abstract class Animal
  {

    public string Name { get; set; }

    private int animalAge; // animalAge field hisoblanadi
    public int Age // bu animalAge ning property si xususiyati hisoblanadi.
    {
      get
      {
        return animalAge;
      }
      set
      {
        if(value>0)
        {
          animalAge=value;
        }
      }
    }

    public Animal(string animalName, int animalAge)
    {
      Age=animalAge;
      Name=animalName;
    }

    public int Agedifference { get; set; }

    public void PrintAgeDifference()
    {
      Console.WriteLine($"The difference between your and {Name}'s age is {Agedifference}");
    }

    public void CompareAges(int userAge)
    {
      if(userAge>Age)
      {
        Console.WriteLine("You are older!");
      }
      else if(userAge==Age)
      {
        Console.WriteLine("You are equal!");
      }
      else
      {
        Console.WriteLine("You are younger!");
      }
    }

    public void TellAboutFriends(string userName, int userAge)
    {
      Console.WriteLine("Let me tell you about my friends.");

      string[] FriendsName = {"Vasya","Kasee",userName};
      int[] FriendsAge = {1, 2, userAge};
      string[] adress = {"Madagascar","New Zealand", "Uzbekistan"};

      for(int i=0; i < FriendsName.Length; i++)
      {
        Console.WriteLine($"{FriendsName[i]} is {FriendsAge[i]} year old. He is from {adress[i]}");
      }
    }

    public int CalculateAgeDifference(int userAge)
    {
      return userAge - Age;
    }

    public void CalculateAgeDifferenceWithNoReturn(int userAge)
    {
      Agedifference = userAge - Age;
    }

    public virtual void Greet(string userName)
    {
      if(userName=="")
      {
        userName="\"Unknown person\"";
      }
      Console.WriteLine($"Hello, {userName}");
    }

    public abstract void AbstraktMethod(string userName);

  }
}

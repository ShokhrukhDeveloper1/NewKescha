namespace NEWKESCHA.Classes
{

    public class Bird : Animal
    {
      public Bird(string animalName, int animalAge) : base(animalName,animalAge)
      {

      }

      public override void Greet(string userName)
      {
        Console.WriteLine($"Hello {userName}");
      }

      public override void AbstraktMethod(string userName)
      {
        Console.WriteLine("Abstract method added");
      }

    }

}
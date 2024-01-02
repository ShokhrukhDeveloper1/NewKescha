namespace NEWKESCHA.Classes
{

  public class Pet : Animal
  {
    public Pet(string animalName,int animalAge):base(animalName,animalAge)
    {

    }

    public override void Greet(string userName)
    {
      System.Console.WriteLine($"Meow, {userName}");
    }

    public override void AbstraktMethod(string userName)
    {
      Console.WriteLine("abstract method added!!!");
    }

  }

}
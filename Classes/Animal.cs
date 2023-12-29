namespace NEWKESCHA.Classes
{
  class Animal
  {
    public Animal(string name, int userAge, int animalAge) // Animal classidan konstruktor yaratish.
    {
      Name=name;
      Age=animalAge;
      Agedifference = userAge - Age;
    }

    public string Name { get; set; }

    private int age; // age field hisoblanadi
    public int Age // bu age ning property si xususiyati hisoblanadi.
    {
      get
      {
        return age;
      }
      set
      {
        if(value>0)
        {
          age=value;
        }
      }
    }

    public int Agedifference { get; set; }

  }
}

namespace NEWKESCHA.Classes
{
  class Animal
  {
    private int age;
    public int Age
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
  }
}

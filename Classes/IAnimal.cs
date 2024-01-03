namespace NEWKESCHA.Classes
{
  public interface IAnimal
  {
    void PrintAgeDifference();
    void CompareAges(int userAge);
    void TellAboutFriends(string userName, int userAge);
    int CalculateAgeDifference(int userAge);
    void CalculateAgeDifferenceWithNoReturn(int userAge);
    void Greet(string userName);
    void AbstraktMethod(string userName);

  }
}
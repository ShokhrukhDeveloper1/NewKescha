using System;

System.Console.Write("Enter your name: ");
string name=Console.ReadLine();

string greetings = $"Hello, {name}";
System.Console.WriteLine(greetings);

string password="";
do
{
  System.Console.Write("Enter password: ");
  password=Console.ReadLine();
}while(password!="123");

System.Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();

System.Console.WriteLine("Converting...");

int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted! {age}");

int keschasAge = 3;
int ageDifference = age - keschasAge;

System.Console.WriteLine($"The difference between your and kescha's age is {ageDifference}");

if(age>keschasAge)
{
  System.Console.WriteLine("You are older!");
}
else if(age==keschasAge)
{
  System.Console.WriteLine("You are equal!");
}
else
{
  System.Console.WriteLine("You are younger!");
}

// System.Console.WriteLine($"you are older than or equal to Kescha: {age>=keschasAge}");
// System.Console.WriteLine($"you are older than Kescha: {age>keschasAge}");
// System.Console.WriteLine($"you are younger than Kescha: {age<keschasAge}");
// System.Console.WriteLine($"you are younger than or equal to Kescha: {age<=keschasAge}");
// System.Console.WriteLine($"Your age is equal to Kescha's age: {age==keschasAge}");
// System.Console.WriteLine($"Your age is not equal to Kescha's age {age!=keschasAge}");
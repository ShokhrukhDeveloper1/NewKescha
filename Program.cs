using System;
using NEWKESCHA.Classes;

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

Animal kescha = new Animal();
kescha.Age=3;

int ageDifference = age - kescha.Age;

System.Console.WriteLine($"The difference between your and kescha's age is {ageDifference}");

if(age>kescha.Age)
{
  System.Console.WriteLine("You are older!");
}
else if(age==kescha.Age)
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

System.Console.WriteLine("Let me tell you about my friends.");

string[] FriendsName = {"Vasya","Kasee","Valya"};
int[] FriendsAge = {1, 2, 2};
string[] adress = {"Madagascar","New Zealand", "Australia"};

for(int i=0;i<FriendsName.Length;i++)
{
  System.Console.WriteLine($"{FriendsName[0]} is {FriendsAge[0]} year old. He is from {adress[0]}");
}
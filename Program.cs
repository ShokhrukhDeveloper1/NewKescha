using System;

System.Console.Write("Enter your name: ");

string name=Console.ReadLine();
string greetings = $"Hello, {name}";

System.Console.WriteLine(greetings);
System.Console.Write("Enter your age: ");

string ageAsString = Console.ReadLine();

System.Console.WriteLine("Converting...");

int age = Convert.ToInt32(ageAsString);

System.Console.WriteLine($"Succesfully converted! {age}");

int keschasAge = 3;
int ageDifference = age - keschasAge;

System.Console.WriteLine($"The difference between your and kescha's age is {ageDifference}");

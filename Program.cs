// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "     Akhmad    ";
firstFriend = firstFriend.Trim();
string secondFriend = "Huda";

string friends = $"My Friends are {firstFriend} and {secondFriend}";
Console.WriteLine(friends);
Console.WriteLine(friends.Replace("and", "Fikron"));
Console.WriteLine(friends);
Console.WriteLine("===========");
friends = friends.Replace("and", "Fikron");
Console.WriteLine(friends);

Console.WriteLine(friends.Contains("Akhmad"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My "));
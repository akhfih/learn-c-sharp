// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

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

int a = 2100000000;
int b = 2100000000;

long c = (long)a + (long)b;
Console.WriteLine(c);

decimal d = 42.1M;
decimal e = 38.2M;
decimal f = d + e;
Console.WriteLine($"The answer is {f}"); */

int a = 5;
int b = 6;
int c = 4;

if((a + b + c > 10) && (a == b)){
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to second");
}
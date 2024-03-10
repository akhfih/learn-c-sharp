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

// int a = 5;
// int b = 6;
// int c = 4;

// if((a + b + c > 10) && (a == b)){
//     Console.WriteLine("The answer is greater than 10.");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to second");
// }

/* int counter = 0;
while(counter < 5)
{
    Console.WriteLine(counter);
    counter++;
}

int counter2 = 0;
do
{
    Console.WriteLine(counter2);
    counter2++;
}
while(counter2 < 5); */


// for (int i= 0; i < 5; i++){
//     if(i ==3)
//     {
//         Console.WriteLine(i);
//     }
// }

//list
// var names = new List<string> { "Scott", "Ana", "Felipe"};

// names.Add("David");
// names.Add("Damian");
// names.Add("Maria");

// foreach (var name in names[2..4])
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// Console.WriteLine(names[0]);
// Console.WriteLine(names[^2]);

//Array
//array lengt is fix
// var names = new String[] { "Scott", "Ana", "Felipe"};
// names = [..names,"Damina"];

//Sorting

// var numbers = new List<int> {45,56,99,48,67,78};

// Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
// numbers.Sort();
// Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

// List<int> scores = [97, 92, 81, 60];

// IEnumerable<int> scoreQuery =
//     from score in scores
//     where score > 80
//     select score;

// foreach(int i in scoreQuery)
// {
//     Console.WriteLine(i + " ");
// }

int[] scores = {90,71,82,93,75,82};

//Query Expression.
IEnumerable<int> scoreQuery = // Query variable
    from score in scores //required
    where score > 80 //optional
    orderby score descending // optional
    select score; //must end with select or group

//Execute the query to produce the results
foreach (int testScore in scoreQuery)
{
    Console.WriteLine(testScore);
}
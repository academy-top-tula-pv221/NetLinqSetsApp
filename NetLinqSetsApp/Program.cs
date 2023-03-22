using ExampleClassLibrary;
using System;

var users1 = new List<User>()
{
    new("Sam", 35),
    new("Bobby", 31),
    new("Timophey", 29),
    new("Joe", 42),
    new("Leopold", 35),
};

foreach (var user in users1)
    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
Console.WriteLine();

var users2 = new List<User>()
{
    new("Sam", 35),
    new("Bob", 31),
    new("Tim", 29),
    new("Joe", 42),
    new("Leo", 35),
};
foreach (var user in users1)
    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
Console.WriteLine();

var usersUnion = users1.Union(users2).Distinct();

Console.WriteLine("Users Union:");
foreach (var user in usersUnion)
    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
Console.WriteLine();


var usersIntersect = users1.Intersect(users2);

Console.WriteLine("Users Intersect:");
foreach (var user in usersIntersect)
    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
Console.WriteLine();

var usersExcept = users1.Except(users2);

Console.WriteLine("Users Except:");
foreach (var user in usersExcept)
    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
Console.WriteLine();




// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var name = Console.ReadLine() ;
var currentDate = DateTime.Now ;
Console.WriteLine($"{Environment.NewLine} user {name} on {currentDate:d} at {currentDate:t}");
Console.WriteLine($"{Environment.NewLine} press any key to exit");
Console.ReadKey(true);
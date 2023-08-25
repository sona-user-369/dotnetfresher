// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var name = Console.ReadLine() ;
var currenDate = DateTime.Now ;
Console.WriteLine($"{Environment.NewLine} user {name} on {currenDate:d} at {currenDate:t}");
Console.WriteLine($"{Environment.NewLine} press any key to exit");
Console.ReadKey(true);
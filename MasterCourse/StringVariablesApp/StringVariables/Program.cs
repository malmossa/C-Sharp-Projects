
string firstName;
string lastName;
string filePath1;
string filePath2;

/* OR
// string firstName = string.Empty;
// string lastName = string.Empty; */

firstName = "Mansor";
lastName = "almossa";

filePath1 = "C:\\Temp\\Demo"; // with scape characters
filePath2 = @"C:\Temp\Demo"; // with string literal characters

string multyLineString = $@"This is where we can wite multy lines: 
1 - item 1.
2 - item 2.
3 - item 3.
";

// string literal
Console.WriteLine(firstName + " " + lastName);

// string interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"The file path 1 is: {filePath1}");
Console.WriteLine($"The file path 2 is: {filePath2}");
Console.WriteLine($"This is a multy lines: {multyLineString}");


Console.ReadLine();
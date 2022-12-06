
string[] myArray1 = new string[4];

myArray1[0] = "Mansor";
myArray1[1] = "Fatna";
myArray1[2] = "Mohammed";
myArray1[3] = "Nujood";

// reassign
myArray1[0] = "Bob";

Console.WriteLine($"Name: {myArray1[0]}");
Console.WriteLine($"Name: {myArray1[1]}");
Console.WriteLine($"Name: {myArray1[2]}");
Console.WriteLine($"Name: {myArray1[3]}");

Console.WriteLine();
// adding data to the array from a line in a CSV file
string data = "Tim,Sue,Bob,Jane,Frank";
string[] myArray2 = data.Split(',');

Console.WriteLine($"Name: {myArray2[0]}");
Console.WriteLine($"Name: {myArray2[1]}");
Console.WriteLine($"Name: {myArray2[2]}");
Console.WriteLine($"Name: {myArray2[3]}");

Console.WriteLine();
// another way to declare an array
string[] myArray3 = { "item 1", "item 2", "item 3", "item 4"};

Console.WriteLine($"Name: {myArray3[0]}");
Console.WriteLine($"Name: {myArray3[1]}");
Console.WriteLine($"Name: {myArray3[2]}");
Console.WriteLine($"Name: {myArray3[3]}");

Console.WriteLine();
// int array
int[] myArray4 = { 1, 2, 3, 4 };

Console.WriteLine($"Number: {myArray4[0]}");
Console.WriteLine($"Number: {myArray4[1]}");
Console.WriteLine($"Number: {myArray4[2]}");
Console.WriteLine($"Number: {myArray4[3]}");

Console.WriteLine();
// print the length of the array
Console.WriteLine($"the lenght is: {myArray2.Length}");

Console.ReadLine();
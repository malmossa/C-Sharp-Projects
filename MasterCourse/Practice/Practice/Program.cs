
List<string> firstNames = new List<string>();

// add to the list
firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");

// access item in the list
Console.WriteLine(firstNames[0]);

Console.WriteLine();

// getting the item in the list
Console.WriteLine(firstNames[firstNames.Count -1]);

// getting the count of the list
Console.WriteLine(firstNames.Count);

Console.WriteLine();

// list of integer
List<int> ages = new List<int>();
ages.Add(10);
ages.Add(20);
ages.Add(30);
ages.Add(40);

// adding to a list from CSV file
string data = "Corey, Smith, Jones";
List<string> lastNames = data.Split(',').ToList();

Console.WriteLine(lastNames[0]);


Console.ReadLine();
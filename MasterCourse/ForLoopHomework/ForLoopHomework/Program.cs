
/* Ask the user for a comma-separated list of first names (no spaces).
   Loop through the array and print "Hello <name>" 
   to the console fir each person.*/


Console.WriteLine("Can you provide a list of first names seperated with a , :");

List<string> firstNames = Console.ReadLine().Split(',').ToList();

foreach (string name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}



Console.ReadLine();


/* Ask the user for a comma-separated list of first names (no spaces).
   Loop through the array and print "Hello <name>" 
   to the console fir each person.*/


Console.WriteLine("Can you provide a list of first names seperated with a , :");

List<string> firstNames = Console.ReadLine().Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}



Console.ReadLine();

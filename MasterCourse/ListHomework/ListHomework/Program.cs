/* Add students to a class roster List until there are no more students.
   Then print out the count of the students to the console.*/

List<string> classList =  new List<string>();

bool addMore = true;

do
{
    Console.Write("Add new student to the class: ");
    classList.Add(Console.ReadLine());

    Console.Write("Do you want to add more students? (y/n) ");

    if (Console.ReadLine().ToLower() == "n")
    {
        addMore= false;
    }
} while (addMore);

Console.WriteLine();

Console.WriteLine($"You have {classList.Count} students is the class.\n");
Console.WriteLine("Goodbay..");


Console.ReadLine();
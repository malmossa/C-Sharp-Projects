/* Create a dictionary list of employee IDs and the name that goes with the ID.
   Fill in a few records. Then ask the user for their ID and return their name.*/

Dictionary<int, string> employee = new Dictionary<int, string>();

employee[01] = "Mansor";
employee[02] = "Fatna";
employee[03] = "Mohammed";
employee[04] = "Nujood";

Console.Write("What is your ID number: ");
string idText = Console.ReadLine();
int id = int.Parse(idText);

Console.WriteLine(employee[id]);

Console.ReadLine();
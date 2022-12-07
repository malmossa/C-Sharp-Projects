
Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}\n");

Dictionary<int, string> students = new Dictionary<int, string>();

students[1] = "Mansor";
students[2] = "Mohammed";
students[3] = "Nujood";

Console.WriteLine($"The student with an ID number 3 is: {students[3]}\n");

Dictionary<string, int> months = new Dictionary<string, int>();

months["January"] = 1;
months["February"] = 2;
months["March"] = 3;

Console.WriteLine($"The number of January is {months["January"]}");





Console.ReadLine();
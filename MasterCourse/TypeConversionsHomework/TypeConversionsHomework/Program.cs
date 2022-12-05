/* Capture a user's age from the console and then identify how old they will be in 25 years,
 as well as how old they were 25 years ago. Print that information to
the console in natural language.*/


Console.Write("How old are you? ");
string ageText = Console.ReadLine();

int age = int.Parse(ageText);

// bool isValid = int.TryParse(ageText, out int age);

Console.WriteLine($"You will be {age + 25} old in 25 years, and you were {age - 25} 25 years age.");






Console.ReadLine();
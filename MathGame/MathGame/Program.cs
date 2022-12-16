using MathGame;

Menu menu = new Menu();

DateTime date = DateTime.Now;

string name = GetName();
menu.ShowMenu(name, date);



string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}



Console.ReadLine();



/* Ask the user to enter a  first name.
   Continue asking for first names until there are no more.
   Then loop through each name using foreach and tell each
   person hello on the Console.*/

bool noMore = true;

do
{
    Console.Write("Please enter a First name: ");
    string firstNAme = Console.ReadLine();

    Console.Write("Do you want to enter onther first name? type y/n : ");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "n")
    {
        noMore = false;
    }
} while (noMore);

/* Build a console Guest Book. Ask the user for their name and how
   many are in their party.
   Keep track of how many people are at the party.
   At the end, print out the guest list and the total number of guests.*/

using GuestBook;

int totalGuests = 0;
string continueLooping;

GuestLogic.WelcomeMessage();

do
{
	string partyName = GuestLogic.GetPartyName();

	totalGuests += GuestLogic.GetPartySize();

	Console.Write("Are there more guests coming (yes/no): ");
	continueLooping= Console.ReadLine();

} while (continueLooping.ToLower() == "yes");










Console.ReadLine();
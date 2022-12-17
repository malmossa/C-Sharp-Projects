/* Build a console Guest Book. Ask the user for their name and how
   many are in their party.
   Keep track of how many people are at the party.
   At the end, print out the guest list and the total number of guests.*/

using GuestBook;


GuestLogic.WelcomeMessage();
var (guests, totalGuests) = GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);

GuestLogic.DisplayGuestCount(totalGuests);











Console.ReadLine();
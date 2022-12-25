

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // initiate list from the PersonModel class 
            List<PersonModel> users = new List<PersonModel>();

            // create user 1 from the PersonModel class
            PersonModel user = new PersonModel();
            user.firstName = "Mansor";
            // add the user to the list
            users.Add(user);

            // create user 2
            user = new PersonModel();
            user.firstName = "Nujood";
            // add to the list
            users.Add(user);

            // print out the list items
            foreach (PersonModel u in users)
            {
                Console.WriteLine(u.firstName);
            }


            



            Console.ReadLine();
        }
    }
}












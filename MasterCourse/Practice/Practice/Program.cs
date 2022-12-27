
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person= new PersonModel();

            person.FirstName = "Mansor";
            person.LastName = "Almossa";
            person.Age = 30;
            person.SSN = "123-45-7890";

            Console.WriteLine(person.SSN);


            Console.ReadLine();
        }
    }
}




            



           












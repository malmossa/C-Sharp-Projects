

namespace DemoLibrary.Models
{
    public class PersonModel
    {
        // public string FirstName { get; set; }
        // public string LastName { get; set; }


        private string firstName;
        private string lastName;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

    }
}

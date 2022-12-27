
namespace Practice
{
    public class PersonModel
    {
        // use of auto properties, note it start with capital letter
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // use of full properties, we use this if we neet to add some logic
        private int _age;
        private string _ssn;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 0 && value < 120)
                {
                    _age = -value;
                } else
                {
                    throw new ArgumentOutOfRangeException("Value", "Age needs to be in a valid range.");
                }
            }
        }

        public string SSN 
        {
            get 
            { 
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }

            set
            {
                _ssn= value;
            }
        }
    }
}

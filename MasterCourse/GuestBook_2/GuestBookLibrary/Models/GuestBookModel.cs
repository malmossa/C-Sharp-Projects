
namespace GuestBookLibrary.Models
{
    public class GuestBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageToHost { get; set; }

        public string DisplayGuestInfo
        {
            get
            {
                return $"{FirstName} {LastName} : {MessageToHost}.";
            }
        }
    }
}

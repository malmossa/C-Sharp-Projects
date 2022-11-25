
namespace ATMApp
{
    public class CardHolder
    {
        String firstName;
        String lastName;
        int cardNumber;
        int pinNumber;
        double balance;

        // constructor
        public CardHolder(String firstName, String lastName, int cardNumber, int pinNumber, double balance) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardNumber = cardNumber;
            this.pinNumber = pinNumber;
            this.balance = balance;


        }

        // getters 
        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public int getCardNumber()
        {
            return cardNumber;
        }

        public int getPinNumber()
        {
            return pinNumber;
        }

        public double getBalance()
        {
            return balance;
        }

        // setters
        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }

        public void setCardNumber(int newCardNumber)
        {
            cardNumber = newCardNumber;
        }

        public void setPinNumber(int newPinNumber)
        {
            pinNumber = newPinNumber;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }


    }
}

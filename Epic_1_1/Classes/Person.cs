
namespace Epic_1_1.Classes
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Address { get; set; }
        private Client Client_ { get; set; }

        public Person(int personId, string address, int clientId, string clientName, int accountNumber)
        {
            PersonId = personId;
            Address = address;
            Client_ = new Client(clientId, clientName, accountNumber);
        }
        public void Deposit(float amount)
        {
            Client_.Deposit(amount);
        }

        public void Withdraw(float amount)
        {
            Client_.Withdraw(amount);
        }

        public void GetBalance()
        {
            Client_.GetBalance();
        }
    }
}


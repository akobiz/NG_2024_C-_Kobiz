using System;

namespace Epic_1_1.Classes
{
    public class Client : Person
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int AccountNumber { get; set; }
        private Balance ClientBalance;

        public Client(int clientId, string clientName, int accountNumber, int personId, string address) : base(personId, address)
        {
            ClientId = clientId;
            ClientName = clientName;
            AccountNumber = accountNumber;
            PersonId = personId;
            Address = address;
            ClientBalance = new Balance(0, ClientId, 0);
        }
        public void Deposit(float amount)
        {
            ClientBalance.UpdateBalance(ClientBalance.GetBalance() + amount);
        }
        public void Withdraw(float amount)
        {
            ClientBalance.UpdateBalance(ClientBalance.GetBalance() - amount);
        }
        public void GetBalance()
        {
            Console.WriteLine($"Balance($): {ClientBalance.GetBalance()}");
        }
    }
}

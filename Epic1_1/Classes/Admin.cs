
using System;

namespace Epic_1_1.Classes
{
    public class Admin : Person
    {
        public int AdminId { get; set; }
        public string AdminRole { get; set; }

        public Admin(int adminId, string adminRole, int personId, string address, int clientId, string clientName, int accountNumber) : base(personId, address, clientId, clientName, accountNumber)
        {
            AdminId = adminId;
            AdminRole = adminRole;
        }
        public Client AddClient(int clientId, string clientName, int accountNumber)
        {
            Client newClient = new Client(clientId, clientName, accountNumber);
            return newClient;
        }
        public Client RemoveClient(Client client)
        {
            client.ClientId = 0;
            client.ClientName = null;
            client.AccountNumber = 0;
            return client;
        }
        public void ViewTransactionHistory(Transaction transaction)
        {
            transaction.GetTransactionDetails();
        }
        public void GenerateReport(Transaction transaction)
        {
            Console.WriteLine($"Transaction time: {transaction.Timestamp}");
            Console.WriteLine($"Transaction ID: {transaction.TransactionId}");
            Console.WriteLine($"Transaction Amount($): {transaction.Amount}");
        }
    }
}

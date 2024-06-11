using System;

namespace Epic_1_1.Classes
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public float Amount { get; set; }
        public string Timestamp { get; set; }

        public void RecordTransaction(int transactionId, float amount, string timestamp)
        {
            TransactionId = transactionId;
            Amount = amount;
            Timestamp = timestamp;
        }
        public void GetTransactionDetails()
        {
            Console.WriteLine($"ID:{TransactionId}\nAmount:{Amount}\nTimestamp: {Timestamp}");
        }
    }
}

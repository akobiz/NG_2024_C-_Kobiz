
namespace Epic_1_1.Classes
{
    public class Person : Client
    {
        public int PersonId { get; set; }
        public string Address { get; set; }

        public Person(int personId, string address, int clientId, string clientName, int accountNumber) : base(clientId, clientName, accountNumber)
        {
            PersonId = personId;
            Address = address;
        }
    }
}

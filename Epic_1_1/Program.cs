using Epic_1_1.Classes;

namespace Epic_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "yes", 1, "name", 1);
            person.Deposit(123.2f);
            Admin admin = new Admin(1, "admin", 1, "admin", 1, "admin", 1);
            var newClient = admin.AddClient(1, "client", 1);
            newClient = admin.RemoveClient(newClient);
        }
    }
}

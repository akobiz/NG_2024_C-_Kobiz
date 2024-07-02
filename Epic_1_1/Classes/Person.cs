
namespace Epic_1_1.Classes
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Address { get; set; }

        public Person(int personId, string address)
        {
            PersonId = personId;
            Address = address;
        }
    }
}
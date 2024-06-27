using Epic2_3.Model;

namespace Epic2_3.Service
{
    public class PersonService
    {
        public Person GetByPhone(IEnumerable<Person> persons, string phoneNumber)
        {
            return persons.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
        }
        public IEnumerable<Person> GetByNames(IEnumerable<Person> persons, string name)
        {
            return persons.Where(x => x.Name.Contains(name)).ToList();
        }
        public IEnumerable<Person> GetAll(IEnumerable<Person> persons)
        {
            return persons.OrderBy(x => x.Name);
        }

        public IEnumerable<Person> AddPerson(IEnumerable<Person> persons, Person person)
        {
            return persons.Append(person);
        }
        public IEnumerable<Person> DeletePersonByPhone(IEnumerable<Person> persons, string phoneNumber)
        {
            return persons.Where(x => x.PhoneNumber != phoneNumber).ToList();
        }
    }
}

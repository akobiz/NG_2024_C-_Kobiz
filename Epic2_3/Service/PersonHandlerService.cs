using Epic2_3.Model;

namespace Epic2_3.Service
{
    public class PersonHandlerService : PersonService
    {
        public void DisplayStartInfo()
        {
            Console.WriteLine("Q - exit");
            Console.WriteLine("A - add");
            Console.WriteLine("GP - Get by phone(display all info)");
            Console.WriteLine("GN - Get by name(display only names)");
            Console.WriteLine("GA - Get all(display ordered by name)");
            Console.WriteLine("D - delete by phone");
            Console.WriteLine("\nChoose an option to continue: ");
        }
        private IEnumerable<Person> DisplayAddInterface(IEnumerable<Person> data)
        {
            Console.WriteLine("Enter Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter phone number (should be unique");
            var phoneNumber = Console.ReadLine();
            var newPerson = new Person();
            newPerson.Name = name;
            newPerson.PhoneNumber = phoneNumber;
            Console.WriteLine("New abonent added succesfully!");
            return AddPerson(data, newPerson);
        }
        private void DisplayGetByPhoneInterface(IEnumerable<Person> data)
        {
            Console.WriteLine("Enter phone number: ");
            var phoneNumber = Console.ReadLine();
            var person = new Person();
            person = data.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
            Console.WriteLine("ABONENT INFO:");
            Console.WriteLine($"NAME: {person.Name} ");
            Console.WriteLine($"PHONE NUMBER: {person.PhoneNumber}");
        }
        private void DisplayGetByNameInterface(IEnumerable<Person> data)
        {
            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            var personList = GetByNames(data, name);
            foreach (var person in personList)
            {
                Console.WriteLine($"NAME: {person.Name}");
                Console.WriteLine($"PHONE NUMBER: {person.PhoneNumber}");
                Console.WriteLine("=============\n");
            }
        }
        private void DisplayGetAllInterface(IEnumerable<Person> data)
        {
            data = GetAll(data);
            Console.WriteLine("All abonents:\n");
            foreach (var person in data)
            {
                Console.WriteLine($"NAME: {person.Name}");
                Console.WriteLine($"PHONE NUMBER: {person.PhoneNumber}");
            }
        }
        private IEnumerable<Person> DisplayDeleteByPhoneInterface(IEnumerable<Person> data)
        {
            Console.WriteLine("Enter phone number to delete data about abonent: ");
            var phoneNumber = Console.ReadLine();
            return DeletePersonByPhone(data, phoneNumber);
        }
        private IEnumerable<Person> ChooseOption(IEnumerable<Person> data, string option)
        {
            switch (option)
            {
                case "a":
                    data = DisplayAddInterface(data);
                    break;
                case "gp":
                    DisplayGetByPhoneInterface(data);
                    break;
                case "gn":
                    DisplayGetByNameInterface(data);
                    break;
                case "ga":
                    DisplayGetAllInterface(data);
                    break;
                case "d":
                    data = DisplayDeleteByPhoneInterface(data);
                    break;
                default:
                    Console.WriteLine("Unkonw command");
                    break;
            }
            return data;
        }
        public void HandlePersonService(IEnumerable<Person> data)
        {
            var userInput = "";
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                DisplayStartInfo();
                userInput = Console.ReadLine().ToLower();
                if (userInput == "q")
                {
                    break;
                }
                else
                {
                    data = ChooseOption(data, userInput);
                }
            }
        }
    }
}

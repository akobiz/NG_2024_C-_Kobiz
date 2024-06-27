using Epic2_3.Model;
using Epic2_3.Service;

IEnumerable<Person> persons = new List<Person>();
var personHandler = new PersonHandlerService();
personHandler.HandlePersonService(persons);
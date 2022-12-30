using RedisDemo.Models;

namespace RedisDemo.Repository
{
    public interface IPerson
    {
         Person AddPerson(Person person);
        IEnumerable<Person> GetAllPersons();
    }
}

using RedisDemo.Models;
using StackExchange.Redis;
using System.Text.Json;

namespace RedisDemo.Repository
{
    public class PersonRepository : IPerson
    {
        private readonly IConnectionMultiplexer _connection;

        public PersonRepository(IConnectionMultiplexer connection)
        {
            _connection = connection;
        }
        public Person AddPerson(Person person)
        {
            var db = _connection.GetDatabase();
            var jsonPerson=JsonSerializer.Serialize(person);
            db.StringSet(person.Name, jsonPerson);
            return person;

        }

        public IEnumerable<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}

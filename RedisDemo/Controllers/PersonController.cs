using Microsoft.AspNetCore.Mvc;
using RedisDemo.Models;
using RedisDemo.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedisDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPerson _iperson;

        public PersonController(IPerson iperson)
        {
            _iperson = iperson;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person person)
        {
          var personResult=  _iperson.AddPerson(person);

            if (personResult != null)
            {
                return Ok(personResult);
            }
            else
                return BadRequest();
            

        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

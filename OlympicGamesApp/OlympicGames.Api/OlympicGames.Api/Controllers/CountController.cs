using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OlympicGames.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        //# Times method called with specific request
        static private int count = 0;//Created only once
        private readonly ILogger<CountController> _logger;

        public CountController(ILogger<CountController> logger)
        {
            this._logger = logger;
        }
  
        // GET: api/<CountController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            count++;
            _logger.LogInformation("Count.Get executed. Count: {count}", count);
            return new string[] { count.ToString() };
        }

        // GET api/<CountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<CountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<CountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<CountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

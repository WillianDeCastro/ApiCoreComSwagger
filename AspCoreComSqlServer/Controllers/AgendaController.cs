using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreComSqlServer.Controllers
{
    [Produces("application/json")]
    [Route("api/Agenda")]
    public class AgendaController : Controller
    {
        // GET: api/Agenda
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "a", "b" };
        }

        // GET: api/Agenda/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Esse é o meu serviço";
        }

        // POST: api/Agenda
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Agenda/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

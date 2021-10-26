using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;
using RestControllerPairProgramming.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestControllerPairProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private readonly IManageMusicRecords mgr = new ManageMusicRecords();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<MusicRecords> Get()
        {
            return mgr.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public MusicRecords Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

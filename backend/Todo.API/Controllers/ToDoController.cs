using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Entities;
using Todo.Repository.Interfaces;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private IToDoRepository repository;

        public ToDoController(IToDoRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ToDo>> Get()
        {
            var todos = repository.Get();

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = todos
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ToDo> Get(int id)
        {
            var todo = repository.Get(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = todo
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ToDo todo)
        {
            repository.Insert(todo);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = todo
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ToDo todo)
        {
            repository.Update(todo);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = todo
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}

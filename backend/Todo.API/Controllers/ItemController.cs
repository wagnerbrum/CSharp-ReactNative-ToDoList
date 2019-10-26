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
    public class ItemController : ControllerBase
    {
        private IItemRepository itemRepository;
        private IToDoRepository toDoRepository;

        public ItemController(IItemRepository itemRepository, IToDoRepository toDoRepository)
        {
            this.itemRepository = itemRepository;
            this.toDoRepository = toDoRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            var items = itemRepository.Get();

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = items
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            var item = itemRepository.Get(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = item
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Item item)
        {
            var todo = toDoRepository.Get(item.todoid);

            if (todo != null)
            {
                item.todo = todo;
            }

            itemRepository.Insert(item);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = item
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Item item)
        {
            itemRepository.Update(item);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = item
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            itemRepository.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}

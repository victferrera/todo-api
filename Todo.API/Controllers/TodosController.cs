using Microsoft.AspNetCore.Mvc;
using Todo.API.Interfaces;
using Todo.API.Models;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("v1/{controller}")]
    public sealed class TodosController : Controller
    {
        private ITodosRepository _repo;

        public TodosController(ITodosRepository repo) => _repo = repo;

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            try
            {
                _repo.Create(item);
                return Created();
            } catch(Exception e)
            {
                return BadRequest("Something went wront trying to save the ToDo item.");
            }
        }
    }
}

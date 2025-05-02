using Microsoft.AspNetCore.Mvc;
using Task_Manager_API.Data;
using Task_Manager_API.Models;

namespace Task_Manager_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _context.Tasks.ToList();
            //return Ok(new { message = "Endpoint funcionando!" });

            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] Models.Task task)
        {
            if (task == null)
            {
                return BadRequest("Task cannot be null");
            }
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAllTasks), new { id = task.Id }, task);
        }
    }
}

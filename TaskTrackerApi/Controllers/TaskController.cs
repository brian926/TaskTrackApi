using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Contracts.Task;

namespace TaskTrackerApi.Controllers
{
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost("/tasks")]
        public IActionResult CreateTask(CreateTaskRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/tasks/{id:guid}")]
        public IActionResult GetTask(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("/tasks/{id:guid}")]
        public IActionResult UpsertTask(Guid id, UpsertTaskRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("/tasks/{id:guid}")]
        public IActionResult DeleteTask(Guid id)
        {
            return Ok(id);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Contracts.Task;
using TaskTrackerApi.Models;

namespace TaskTrackerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateTask(CreateTaskRequest request)
        {
            var task = new Tasks(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Reminder);

            var response = new Tasks(
                task.Id,
                task.Name,
                task.Description,
                task.StartDateTime,
                task.EndDateTime,
                task.LastModifiedDateTime,
                task.Reminder
            );

            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, value: response);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetTask(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertTask(Guid id, UpsertTaskRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteTask(Guid id)
        {
            return Ok(id);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Contracts.Task;
using TaskTrackerApi.Models;
using TaskTrackerApi.Services.Task;

namespace TaskTrackerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskSerivce;
        public TasksController(ITaskService taskService)
        {
            _taskSerivce = taskService;
        }

        [HttpPost]
        public IActionResult CreateTask(CreateTaskRequest request)
        {
            var newTask = new Tasks(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Reminder);

            _taskSerivce.CreateTask(newTask);

            var response = new Tasks(
                newTask.Id,
                newTask.Name,
                newTask.Description,
                newTask.StartDateTime,
                newTask.EndDateTime,
                newTask.LastModifiedDateTime,
                newTask.Reminder
            );

            return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, value: response);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetTask(Guid id)
        {
            Tasks task = _taskSerivce.GetTask(id);
            var response = new Tasks(
                task.Id,
                task.Name,
                task.Description,
                task.StartDateTime,
                task.EndDateTime,
                task.LastModifiedDateTime,
                task.Reminder
            );
            return Ok(response);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertTask(Guid id, UpsertTaskRequest request)
        {
            var task = new Tasks(
                id,
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Reminder
            );

            _taskSerivce.UpsertTask(task);

            // TODO: return 201 is new task was created
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteTask(Guid id)
        {
            _taskSerivce.DeleteTask(id);
            return NoContent();
        }
    }
}
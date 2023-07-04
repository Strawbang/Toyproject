using Microsoft.AspNetCore.Mvc;
using Toyproject.Repositories;

namespace Toyproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {

        private readonly ILogger<TasksController> _logger;
        private readonly ITasksRepository _taskRepository;

        public TasksController(ILogger<TasksController> logger, ITasksRepository tasksRepository)
        {
            _logger = logger;
            _taskRepository = tasksRepository;
        }

        [HttpGet(Name = "Listing")]
        public IEnumerable<Tasks> Get()
        {
            foreach(var item in _taskRepository.GetTasks())
            {
                yield return new Tasks() { Title = item };
            }
        }
    }
}

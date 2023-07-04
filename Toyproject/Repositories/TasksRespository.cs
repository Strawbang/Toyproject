namespace Toyproject.Repositories
{
    public class TasksRespository : ITasksRepository
    {
        private static readonly List<string> Summaries =
        new() { "Sleep", "Eat", "Work", "Meeting", "Exercice" };

        public List<string> GetTasks() => Summaries;

    }
}

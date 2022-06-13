namespace ScrumBoards.src.Task.TaskCreator;

public class TaskCreator : ITaskCreator
{
    public ITask CreateTask(
        string name,
        string description,
        TaskPriority priority
    ) {
        return new Task(name, description, priority);
    }
}

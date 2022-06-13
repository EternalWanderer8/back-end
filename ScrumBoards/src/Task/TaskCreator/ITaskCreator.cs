namespace ScrumBoards.src.Task.TaskCreator;

public interface ITaskCreator
{
    public ITask CreateTask(
        string name,
        string description,
        TaskPriority priority
    );
}

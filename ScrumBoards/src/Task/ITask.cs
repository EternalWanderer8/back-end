namespace ScrumBoards.src.Task;

public interface ITask
{
    public string Uuid { get; }

    public string Name { get; }

    public string Description { get; }

    public TaskPriority Priority { get; }
}

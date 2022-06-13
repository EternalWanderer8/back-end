namespace ScrumBoards.src.Task;

public class Task : ITask
{
    private readonly string _uuid;
    private readonly string _name;
    private readonly string _description;
    private readonly TaskPriority _priority;

    public Task(
        string name,
        string description,
        TaskPriority priority
    ) {
        _uuid = Guid.NewGuid().ToString();
        _name = name;
        _description = description;
        _priority = priority;
    }

    public string Uuid { get; }

    public string Name { get; }

    public string Description { get; }

    public TaskPriority Priority { get; }
}

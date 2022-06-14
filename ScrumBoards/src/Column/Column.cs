namespace ScrumBoards.src.Column;

using ScrumBoards.src.Task;
using ScrumBoards.src.Exception;

public class Column : IColumn
{
    private readonly string _uuid;
    private readonly string _name;
    private readonly List<ITask> _tasks;

    public Column(string name)
    {
        _uuid = Guid.NewGuid().ToString();
        _name = name;
        _tasks = new List<ITask>();
    }

    public void InsertTask(ITask task)
    {
        _tasks.Add(task);
    }

    public void RemoveTask(string taskUuid)
    {
        int indexOfTask = _tasks.FindIndex(task => task.Uuid == taskUuid);
        if (indexOfTask == -1)
        {
            throw new ElementNotFoundException("There is no task with such UUID");
        }

        _tasks.RemoveAt(indexOfTask);
    }

    public bool HasTask(string taskUuid)
    {
        return _tasks.FindIndex(task => task.Uuid == taskUuid) != -1;
    }

    public ITask? GetTask(string taskUuid)
    {
        try
        {
            return GetTaskByUUID(taskUuid);
        }
        catch (ElementNotFoundException)
        {
            return null;
        }
    }

    public string Uuid { get; }

    public string Name { get; set; }

    public List<ITask> Tasks { get; }

    private ITask GetTaskByUUID(string taskUuid)
    {
        ITask? task = _tasks.Find(task => task.Uuid == taskUuid);

        if (task == null)
        {
            throw new ElementNotFoundException("There is no task with such UUID");
        }

        return task;
    }
}

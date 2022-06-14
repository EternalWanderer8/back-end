namespace ScrumBoards.src.Column;

using ScrumBoards.src.Task;

public interface IColumn
{
    public void InsertTask(ITask task);

    public bool HasTask(string taskUuid);

    public void RemoveTask(string taskUuid);

    public ITask? GetTask(string taskUuid);

    public string Uuid { get; }

    public string Name { get; set; }

    public List<ITask> Tasks { get; }
}

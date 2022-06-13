namespace ScrumBoards.src.Column;

using ScrumBoards.src.Task;

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

    public string Uuid { get; }

    public string Name { get; set; }

    public List<ITask> Tasks { get; }
}

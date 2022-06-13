namespace ScrumBoards.src.Column;

using ScrumBoards.src.Task;

public interface IColumn
{
    public string Uuid { get; }

    public string Name { get; set; }

    public List<ITask> Tasks { get; }
}

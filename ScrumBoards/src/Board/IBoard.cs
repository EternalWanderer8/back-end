namespace ScrumBoards.src.Board;

using ScrumBoards.src.Column;
using ScrumBoards.src.Task;

public interface IBoard
{
    public void AddColumn(IColumn column);

    public int GetColumnsCount();

    public void AddTask(ITask task);

    public string Name { get; }

    public List<IColumn> Columns { get; }

    public IColumn? GetColumn(string columnUuid);
}

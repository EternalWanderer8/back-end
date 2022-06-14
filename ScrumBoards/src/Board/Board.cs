namespace ScrumBoards.src.Board;

using ScrumBoards.src.Exception;
using ScrumBoards.src.Column;
using ScrumBoards.src.Task;

public class Board : IBoard
{
    private const int MAX_COLUMNS_COUNT = 10;

    private readonly string _uuid;
    private readonly string _name;
    private List<IColumn> _columns;

    public Board(string name)
    {
        _uuid = Guid.NewGuid().ToString();
        _name = name;
        _columns = new List<IColumn>();
    }

    public void AddColumn(IColumn column)
    {
        if (GetColumnsCount() > MAX_COLUMNS_COUNT)
        {
            throw new ColumnMaxCountExceededException("Board can contain " +
                "not more than 10 columns");
        }

        int columnIndex = _columns.FindIndex(c => c.Name == column.Name);

        if (columnIndex != -1)
        {
            throw new ColumnAlreadyExists("Column with such name already " +
                "exists in this board. Consider use it.");
        }

        if (_columns.Contains(column))
        {
            throw new ColumnAlreadyExists("You have already added thi column. " +
                "Consider use it.");
        }

        _columns.Add(column);
    }

    public int GetColumnsCount()
    {
        return _columns.Count;
    }

    public void AddTask(ITask task)
    {
        if (IsTaskOnBoard(task.Uuid))
        {
            throw new TaskAlreadyAddedException("This task is already on board. " +
                "Consider moving it to another column");
        }

        if (GetColumnsCount() == 0)
        {
            throw new NoColumnsException("You can't add a task " +
                "on board with no columns!");
        }

        _columns[0].InsertTask(task);
    }

    public void MoveTask(string taskUuid, string columnUuid)
    {
        try
        {
            IColumn newTaskColumn = GetColumnByUUID(columnUuid);

            if (!IsTaskOnBoard(taskUuid))
            {
                throw new ElementNotFoundException("There is no such " +
                    "task on board!");
            }

            IColumn oldTaskColumn = GetColumnByTask(taskUuid);
            ITask? task = oldTaskColumn.GetTask(taskUuid);

            if (task == null)
            {
                throw new InvalidStateException("Runtime error");
            }

            newTaskColumn.InsertTask(task);
            oldTaskColumn.RemoveTask(taskUuid);
        }
        catch (ElementNotFoundException exception)
        {
            throw exception;
        }

    }

    public string Name { get; }

    public List<IColumn> Columns { get; }

    public IColumn? GetColumn(string columnUuid)
    {
        try
        {
            return GetColumnByUUID(columnUuid);
        }
        catch (ElementNotFoundException)
        {
            return null;
        }
    }

    private IColumn GetColumnByUUID(string columnUuid)
    {
        IColumn? column = _columns.Find(column => column.Uuid == columnUuid);

        if (column == null)
        {
            throw new ElementNotFoundException("There is no column with such UUID");
        }

        return column;
    }

    private IColumn GetColumnByTask(string taskUuid)
    {
        IColumn? column = _columns.Find(column => column.HasTask(taskUuid));

        if (column == null)
        {
            throw new ElementNotFoundException("There is no column with such task");
        }

        return column;
    }

    private bool IsTaskOnBoard(string taskUuid)
    {
        int columnIndex = _columns.FindIndex(column => column.HasTask(taskUuid));

        return columnIndex != -1;
    }
}

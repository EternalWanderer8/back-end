namespace ScrumBoards.src.Board;

using ScrumBoards.src.Exception;
using ScrumBoards.src.Column;

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

        _columns.Add(column);
    }

    public int GetColumnsCount()
    {
        return _columns.Count;
    }

    public string Name { get; }

    public List<IColumn> Columns { get; }

    private IColumn GetColumnByUUID(string columnUuid)
    {
        IColumn? column = _columns.Find(column => column.Uuid == columnUuid);

        if (column == null)
        {
            throw new
        }
    }
}

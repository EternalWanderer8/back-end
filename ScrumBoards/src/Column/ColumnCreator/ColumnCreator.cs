namespace ScrumBoards.src.Column.ColumnCreator;

public class ColumnCreator : IColumnCreator
{
    public IColumn CreateColumn(string name)
    {
        return new Column(name);
    }
}

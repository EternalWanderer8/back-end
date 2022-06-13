namespace ScrumBoards.src.Board;

using ScrumBoards.src.Column;

public interface IBoard
{
    public void AddColumn(IColumn column);

    public int GetColumnsCount();

    public string Name { get; }

    public List<IColumn> Columns { get; }
}

namespace ScrumBoards.src.Exception;

public class ColumnAlreadyExists : System.Exception
{
    public ColumnAlreadyExists()
    {
    }

    public ColumnAlreadyExists(string message)
        : base(message)
    {
    }

    public ColumnAlreadyExists(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

namespace ScrumBoards.src.Exception;

public class ColumnMaxCountExceededException : System.Exception
{
    public ColumnMaxCountExceededException()
    {
    }

    public ColumnMaxCountExceededException(string message)
        : base(message)
    {
    }

    public ColumnMaxCountExceededException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

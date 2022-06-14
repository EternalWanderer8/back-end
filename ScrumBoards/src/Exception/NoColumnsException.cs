namespace ScrumBoards.src.Exception;

public class NoColumnsException : System.Exception
{
    public NoColumnsException()
    {
    }

    public NoColumnsException(string message)
        : base(message)
    {
    }

    public NoColumnsException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

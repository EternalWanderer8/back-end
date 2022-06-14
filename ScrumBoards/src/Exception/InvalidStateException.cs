namespace ScrumBoards.src.Exception;

public class InvalidStateException : System.Exception
{
    public InvalidStateException()
    {
    }

    public InvalidStateException(string message)
        : base(message)
    {
    }

    public InvalidStateException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

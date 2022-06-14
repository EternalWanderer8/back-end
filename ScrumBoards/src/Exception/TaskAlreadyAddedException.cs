namespace ScrumBoards.src.Exception;

public class TaskAlreadyAddedException : System.Exception
{
    public TaskAlreadyAddedException()
    {
    }

    public TaskAlreadyAddedException(string message)
        : base(message)
    {
    }

    public TaskAlreadyAddedException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

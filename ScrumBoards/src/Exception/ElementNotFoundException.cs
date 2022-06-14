namespace ScrumBoards.src.Exception;

public class ElementNotFoundException : System.Exception
{
    public ElementNotFoundException()
    {
    }

    public ElementNotFoundException(string message)
        : base(message)
    {
    }

    public ElementNotFoundException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}

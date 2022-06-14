namespace ScrumBoard;

using ScrumBoards.src.Column;
using ScrumBoards.src.Column.ColumnCreator;
using ScrumBoards.src.Task;
using ScrumBoards.src.Task.TaskCreator;
using TaskCreator = ScrumBoards.src.Task.TaskCreator.TaskCreator;

class Program
{
    public static void Main()
    {
        try
        {
            ITaskCreator taskCreator = new TaskCreator();
            IColumnCreator columnCreator = new ColumnCreator();

            IColumn column = columnCreator.CreateColumn("In Progress");
            ITask firstTask = taskCreator.CreateTask("Add plus to calculator", "Add plus to calculator to increase money input", TaskPriority.NORMAL);
            ITask secondTask = taskCreator.CreateTask("Add minus to calculator", "Add minus to calculator to increase money input", TaskPriority.NORMAL);

            column.InsertTask(firstTask);
            column.InsertTask(secondTask);
            Console.WriteLine(column.GetTask(firstTask.Uuid)?.Name + ' ' + column.GetTask(firstTask.Uuid)?.Description);
            Console.WriteLine(column.Tasks[0].Uuid + ' ' + column.Tasks[1].Uuid);

        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

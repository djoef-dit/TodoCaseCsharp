using System.Collections.Generic;

namespace Todo.Domain.Model
{
    public interface ITodoRepository
    {
        List<TodoModel> GetToDos();

        List<TodoModel> GetCompletedToDos();

        void AddToDo(TodoModel toDo);
    }
}

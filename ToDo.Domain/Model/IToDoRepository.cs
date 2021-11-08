using System.Collections.Generic;

namespace ToDo.Domain.Model
{
    public interface IToDoRepository
    {
        List<ToDo> GetToDos();

        List<ToDo> GetCompletedToDos();

        void AddToDo(ToDo toDo);
    }
}

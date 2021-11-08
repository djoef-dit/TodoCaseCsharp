using System.Collections.Generic;

namespace ToDo.Domain.Model
{
    public class ToDoRepository : IToDoRepository
    {
        private List<ToDo> _toDoList = new List<ToDo>()
        {
            new ToDo()
            {
                Completed = true,
                Name = "læs opgaven"
            },
            new ToDo()
            {
                Completed = false,
                Name = "løs opgaven"
            },
            new ToDo()
            {
                Completed = false,
                Name = "jublehyl"
            }
        };

        public List<ToDo> GetToDos()
        {
            return _toDoList;
        }

        public List<ToDo> GetCompletedToDos()
        {
            return _toDoList;
        }

        public void AddToDo(ToDo toDo)
        {
            _toDoList.Add(toDo);
        }
    }
}

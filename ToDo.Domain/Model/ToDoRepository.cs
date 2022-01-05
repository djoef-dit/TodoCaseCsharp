using System.Collections.Generic;
using System.Linq;

namespace Todo.Domain.Model
{
    public class ToDoRepository : ITodoRepository
    {
        private List<TodoModel> _toDoList = new List<TodoModel>()
        {
            new TodoModel()
            {
                Completed = true,
                Name = "læs opgaven"
            },
            new TodoModel()
            {
                Completed = false,
                Name = "løs opgaven"
            },
            new TodoModel()
            {
                Completed = false,
                Name = "jublehyl"
            }
        };

        public List<TodoModel> GetToDos()
        {
            return _toDoList;
        }

        public List<TodoModel> GetCompletedToDos()
        {
            return _toDoList.Where(todo => !todo.Completed).ToList();
        }

        public void AddToDo(TodoModel toDo)
        {
            _toDoList.Add(toDo);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todo.Domain.Model;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        public ToDoController()
        {
        }

        [HttpGet]
        public IEnumerable<TodoModel> Get()
        {
            return null;
        }

    }
}

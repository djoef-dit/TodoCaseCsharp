using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Todo.APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        public ToDoController()
        {
        }

        [HttpGet]
        public IEnumerable<ToDo.Domain.Model.ToDo> Get()
        {

            return null;
        }

    }
}

using ApplicationPool.Contex;
using ApplicationPool.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPool.Repositories;

namespace ApplicationPool.Controllers
{
    public class TodoController : Controller
    {
        public ToDoContext context { get; set; }
        public IToDoRepository _ToDoRepository { get; set; }

        public TodoController(ToDoContext toDoContext, IToDoRepository toDoRepository)
        {
            context = toDoContext;
            _ToDoRepository = toDoRepository;
        }

        public IActionResult Index()
        {
            var toDos = context.ToDos.ToList();

            return View(toDos);
        }

        [HttpPost]
        [Route("api/todo")]
        public IActionResult RequestTodo([FromBody] TodoRequestModel requestModel)
        {
            
            //var entry = context.ToDos.Add(new Models.ToDoModel { Name = requestModel.Name });
            //context.SaveChanges();
            return Ok(_ToDoRepository.Create(requestModel));
        }

        [HttpDelete]
        [Route("api/todo/{todoId}")]
        public IActionResult DeleteTodo([FromRoute] int todoId)
        {
            var todo = context.ToDos.Find(todoId);
            context.ToDos.Remove(todo);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTodo([FromRoute] int todoId)
        {
            var todo = context.ToDos.Find(todoId);
            context.ToDos.Update(todo);
            context.SaveChanges();
            return Ok();
        }

    }
}

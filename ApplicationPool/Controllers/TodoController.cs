using ApplicationPool.Contex;
using ApplicationPool.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationPool.Models;
using ApplicationPool.Models.Request;
using ApplicationPool.Repositories;

namespace ApplicationPool.Controllers
{
    public class TodoController : Controller
    {
        public ToDoContext context { get; set; }
        public IRepository<ToDoModel> _ToDoRepository { get; set; }

        public TodoController(ToDoContext toDoContext, IRepository<ToDoModel> toDoRepository)
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
            return Ok(_ToDoRepository.Add(requestModel));
        }

        [HttpDelete]
        [Route("api/todo/{todoId}")]
        public IActionResult DeleteTodo([FromRoute] int todoId)
        {
            // var todo = context.ToDos.Find(todoId);
            // context.ToDos.Remove(todo);
            // context.SaveChanges();
            _ToDoRepository.Delete(todoId);
            return Ok();
        }

        [HttpPut]
        [Route("api/todo/{todoId}")]
        public IActionResult UpdateTodo([FromRoute] int todoId, [FromBody] TodoUpdateModel model)
        {
            // var todo = context.ToDos.Find(todoId);
            // todo.IsDone = model.IsDone;
            // context.SaveChanges();
            _ToDoRepository.Update(todoId,model);
            return Ok();
        }

    }
}

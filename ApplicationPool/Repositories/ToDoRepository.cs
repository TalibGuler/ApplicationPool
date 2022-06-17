using ApplicationPool.Contex;
using ApplicationPool.Models;
using ApplicationPool.Models.Request;
using ApplicationPool.Models.Response;

namespace ApplicationPool.Repositories
{
    public class ToDoRepository : IRepository<ToDoModel>
    {
        public ToDoContext context { get; set; }

        public ToDoRepository(ToDoContext toDoContext)
        {
            context = toDoContext;
        }

        public ToDoModel Add(TodoRequestModel requestModel)
        {
            var entry = context.ToDos.Add(new Models.ToDoModel { Name = requestModel.Name });
            context.SaveChanges();
            return entry.Entity;
        }
        
        public void Delete(int todoId)
        {
            var todo = context.ToDos.Find(todoId);
            context.ToDos.Remove(todo);
            context.SaveChanges();
        }
        
        public void Update(int todoId,TodoUpdateModel model)
        {
            var todo = context.ToDos.Find(todoId);
            todo.IsDone = model.IsDone;
            context.SaveChanges();
        }
    }
}
using ApplicationPool.Contex;
using ApplicationPool.Models;
using ApplicationPool.Models.Response;

namespace ApplicationPool.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        public ToDoContext context { get; set; }
        
        public ToDoRepository(ToDoContext toDoContext)
        {
            context = toDoContext;
        }
        public ToDoModel Create(TodoRequestModel requestModel)
        {
            var entry = context.ToDos.Add(new Models.ToDoModel { Name = requestModel.Name });
            context.SaveChanges();
            return entry.Entity;
        }
    }
    
}
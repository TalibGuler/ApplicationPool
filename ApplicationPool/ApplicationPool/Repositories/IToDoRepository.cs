using ApplicationPool.Models;
using ApplicationPool.Models.Response;

namespace ApplicationPool.Repositories
{
    public interface IToDoRepository
    { 
        ToDoModel Create(TodoRequestModel requestModel);
    }
}
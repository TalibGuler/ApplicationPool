using ApplicationPool.Models;
using ApplicationPool.Models.Request;
using ApplicationPool.Models.Response;

namespace ApplicationPool.Repositories
{
    public interface IRepository<T>
    { 
        T Add(TodoRequestModel requestModel);
        void Delete(int todoId);
        void Update(int todoId,TodoUpdateModel model);

    }
}
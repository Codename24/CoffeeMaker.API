using CoffeeMaker.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeMaker.DataAccess.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}

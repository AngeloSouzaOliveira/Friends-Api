using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.InterfaceGeneric
{
    public interface IGeneric<T> where T : class
    {
        Task<List<T>> List();

        Task<T> GetById(int id);

        Task Create(T Object);

        Task Update(T Object);

        Task Delete(T Object);


    }
}

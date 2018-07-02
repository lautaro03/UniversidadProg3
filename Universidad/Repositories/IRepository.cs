using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Models;

namespace Universidad.Repositories
{
    public interface IRepository<T> where T : ModelBase
    {
        List<T> Listar();
        T getById(int id);
        bool Add(T entidad);
        bool Update(T entidad);
        bool Del(int id);
        void Save();
        bool IsExist(int id);
    }
}

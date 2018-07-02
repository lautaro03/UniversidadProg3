using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Models;

namespace Universidad.Repositories
{
    public interface ICursadaRepository
    {
        List<CursadaAlumno> Listar();
        CursadaAlumno getById(int Aid, int Cid);
        bool Add(CursadaAlumno entidad);
        bool Update(CursadaAlumno entidad);
        bool Del(int Aid, int Cid);
        void Save();
        bool IsExist(int Aid, int Cid);
    }
}

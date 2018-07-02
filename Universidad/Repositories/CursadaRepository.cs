using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Models;

namespace Universidad.Repositories
{
    public class CursadaRepository : ICursadaRepository, IDisposable
    {
        private ApplicationDbContext db;
        public CursadaRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public bool Add(CursadaAlumno model)
        {
            try
            {
                db.CursadaAlumnos.Add(model);
                Save();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Del(int Aid, int Cid)
        {
            try
            {
                db.CursadaAlumnos.Remove(getById(Aid,Cid));
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public CursadaAlumno getById(int Aid,int Cid)
        {
            return db.CursadaAlumnos.Where(x => x.CatedraID == Cid && x.AlumnoID == Aid).FirstOrDefault();
        }

        public bool IsExist(int Aid, int Cid)
        {
            return db.CursadaAlumnos.Where(x => x.CatedraID == Cid && x.AlumnoID == Aid).Any();
        }

        public List<CursadaAlumno> Listar()
        {
            return db.CursadaAlumnos.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(CursadaAlumno model)
        {
            try
            {
                db.CursadaAlumnos.Update(model);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

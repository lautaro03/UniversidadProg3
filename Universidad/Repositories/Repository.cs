using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Models;

namespace Universidad.Repositories
{
    public class Repository<M> : IRepository<M>, IDisposable where M : ModelBase
    {
        private ApplicationDbContext db;
        private DbSet<M> Tabla;

        public Repository(ApplicationDbContext _db)
        {
            db = _db;
            Tabla = db.Set<M>();
        }

        public bool Add(M entidad)
        {
            try
            {
                Tabla.Add(entidad);
                Save();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Del(int ID)
        {
            try
            {
                M obj = this.getById(ID);
                if (obj == null)
                    throw new Exception();
                else
                {
                    Tabla.Remove(obj);
                    Save();
                    return true;
                }      
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public M getById(int id)
        {
            return Tabla.Where(x => x.ID == id).FirstOrDefault();
        }

        public bool IsExist(int id)
        {
            return Tabla.Where(x => x.ID == id).Any();
        }

        public List<M> Listar()
        {
            return Tabla.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(M entidad)
        {
            try
            {
                Tabla.Update(entidad);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

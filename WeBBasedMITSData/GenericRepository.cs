using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBBasedMITSData
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        MITSDatabaseEntities Dbcontext = null;
        protected DbSet<T> table = null;
        public GenericRepository(MITSDatabaseEntities _context)
        {
            this.Dbcontext = _context;
            table = _context.Set<T>();
        }

        public GenericRepository()
        {
            this.Dbcontext = new MITSDatabaseEntities();
            table = Dbcontext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();

        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            Dbcontext.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            // Dbcontext.SaveChanges();
            try
            {
                Dbcontext.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
    }
}

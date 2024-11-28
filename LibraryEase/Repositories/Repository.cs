using LibraryEase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEase.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbContext _context; // dbContext generico
        private readonly DbSet<T> _dbSet; // dbSet generico


        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // Ejemplo de como usar el metodo generico Add
        // Repository repo = new<Book>(LibraryDbContext _context);
        // var object = new Book { }
        // repo.Add(object)
        
        public void Delete(int id)
        {
            var entity = _dbSet.Find(id); // search by id the generic entity
            if (entity != null) { // if it isn't null
                _dbSet.Remove(entity); // removes the generic entity
                _context.SaveChanges();
            }

        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}

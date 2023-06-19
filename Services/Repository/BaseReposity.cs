using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class BaseReposity<TEntity> where TEntity : class
    {
        public MyApplicationDBContext _context;
        public DbSet<TEntity> _dbSet;

        public BaseReposity(MyApplicationDBContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
        }

        public bool Delete(TEntity item)
        {
            try
            {
                _dbSet.Remove(item);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public void Update(TEntity item)
        {
            var tracker = _context.Attach(item);
            tracker.State = EntityState.Modified;
        }

    }
}

using Domain.Interface.Base;
using Domain.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntidadeBase
    {
        protected DbSet<TEntity> DbSet;
        private readonly Context.DBContext _context;

        public Repository(Context.DBContext context)
        {
            this._context = context;
            DbSet = _context.Set<TEntity>();
        }
        public void Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            _context.SaveChanges();
        }

        public TEntity BuscarPorId(long id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return DbSet.ToList();
        }

        public async Task Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            var entityDB = DbSet.Find(entity.id);
            _context.Entry(entityDB).CurrentValues.SetValues(entity);
            DbSet.Update(entityDB);
            _context.SaveChanges();
        }
    }
}

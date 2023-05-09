using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Base;

namespace Domain.Interface.Base
{
    public interface IRepository<TEntity> where TEntity : EntidadeBase
    {
        void Adicionar(TEntity entity);
        TEntity BuscarPorId(long id);
        IEnumerable<TEntity> BuscarTodos();
        void Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
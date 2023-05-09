using Domain.Model;
using Domain.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        IEnumerable<Empresa> GetFornecedores(long id);
        IEnumerable<Empresa> GetAll();
    }
}

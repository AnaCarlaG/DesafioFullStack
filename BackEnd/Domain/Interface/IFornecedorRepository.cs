using Domain.Model;
using Domain.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> GetEmpresas(long id);
        IEnumerable<Fornecedor> GetAll();
    }
}

using Domain.Model;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        private readonly Infra.Context.DBContext _context;
        public FornecedorRepository(Infra.Context.DBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Fornecedor> GetEmpresas(long id)
        {
            var loca = _context.Fornecedores.Include(x => x.Empresas).AsEnumerable().Where(x => x.id == id);
            return loca;
        }
        public IEnumerable<Fornecedor> GetAll()
        {
            return _context.Fornecedores.Include(x => x.Empresas).AsEnumerable();
        }
    }
}

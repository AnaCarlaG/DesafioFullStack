using Domain.Model;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class EmpresaRepository : Repository<Empresa>, IEmpresaRepository
    {
        private readonly Infra.Context.DBContext _context;
        public EmpresaRepository(Infra.Context.DBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Empresa> GetFornecedores(long id)
        {
            var loca = _context.Empresas.Include(x => x.Fornecedor).AsEnumerable().Where(x => x.id == id);
            return loca;
        }
        public IEnumerable<Empresa> GetAll()
        {
            return _context.Empresas.Include(x => x.Fornecedor).AsEnumerable();
        }
    }
}

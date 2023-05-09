using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interface
{
    public interface IEmpresaService
    {
        void Add(EmpresaViewModel empresa);
        EmpresaViewModel GetId(long id);
        IEnumerable<EmpresaViewModel> GetAll();
        IEnumerable<EmpresaViewModel> GetAllFornecedores(long id);
        void Update(EmpresaViewModel empresa);
        void Delete(long id);

    }
}

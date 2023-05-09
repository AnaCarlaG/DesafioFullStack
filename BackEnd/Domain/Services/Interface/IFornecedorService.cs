
using Domain.ViewModel;

namespace Domain.Services.Interface
{
    public interface IFornecedorService
    {
        void Add(FornecedorViewModel fornecedor);
        FornecedorViewModel GetId(long id);
        IEnumerable<FornecedorViewModel> GetAll();
        void Update(FornecedorViewModel fornecedor);
        void Delete(long id);
    }
}

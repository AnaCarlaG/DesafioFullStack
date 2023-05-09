using AutoMapper;
using Domain.Interface;
using Domain.Model;
using Domain.Services.Interface;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _FornecedorRepo;
        private readonly IMapper _mapper;
        public FornecedorService(IFornecedorRepository Fornecedor, IMapper mapper)
        {
            _FornecedorRepo = Fornecedor;
            _mapper = mapper;
        }

        public void Add(FornecedorViewModel fornecedor)
        {
            var prod = _mapper.Map<Fornecedor>(fornecedor);
            if (prod.id == 0)
            {
                _FornecedorRepo.Adicionar(prod);
            }
            else
            {
                _FornecedorRepo.Update(prod);
            }
        }

        public void Delete(long id)
        {
            var prod = _FornecedorRepo.BuscarPorId(id);
            _FornecedorRepo.Delete(prod);
        }

        public IEnumerable<FornecedorViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(_FornecedorRepo.GetAll());
        }

        public FornecedorViewModel GetId(long id)
        {
            return _mapper.Map<FornecedorViewModel>(_FornecedorRepo.BuscarPorId(id));
        }

        public void Update(FornecedorViewModel Fornecedor)
        {
            _FornecedorRepo.Update(_mapper.Map<Fornecedor>(Fornecedor));
        }
        public IEnumerable<FornecedorViewModel> GetAllEmpresas(long id)
        {
            var loca = _FornecedorRepo.GetEmpresas(id);
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(loca);

        }
    }
}

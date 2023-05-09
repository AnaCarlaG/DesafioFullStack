using AutoMapper;
using Domain.Interface;
using Domain.Model;
using Domain.Services.Interface;
using Domain.ViewModel;

namespace Domain.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepo;
        private readonly IMapper _mapper;

        public EmpresaService(IEmpresaRepository location, IMapper mapper)
        {
            _empresaRepo = location;
            _mapper = mapper;
        }

        public void Add(EmpresaViewModel location)
        {
            var local = _mapper.Map<Empresa>(location);
            if (local.id == 0)
            {
                _empresaRepo.Adicionar(local);
            }
            else
            {
                _empresaRepo.Update(local);
            }
        }

        public void Delete(long id)
        {
            var prod = _empresaRepo.BuscarPorId(id);
            _empresaRepo.Delete(prod);
        }

        public IEnumerable<EmpresaViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<EmpresaViewModel>>(_empresaRepo.GetAll());
        }

        public IEnumerable<EmpresaViewModel> GetAllFornecedores(long id)
        {
            var loca = _empresaRepo.GetFornecedores(id);
            return _mapper.Map<IEnumerable<EmpresaViewModel>>(loca);

        }

        public EmpresaViewModel GetId(long id)
        {
            return _mapper.Map<EmpresaViewModel>(_empresaRepo.BuscarPorId(id));
        }

        public void Update(EmpresaViewModel empr)
        {
            var empresa = _mapper.Map<Empresa>(empr);
            _empresaRepo.Update(empresa);
        }
    }
}

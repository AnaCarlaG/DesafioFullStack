using AutoMapper;
using Domain.Model;
using Domain.ViewModel;

namespace Domain.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap< EmpresaViewModel, Empresa>();
            CreateMap<FornecedorViewModel, Fornecedor>();
        }
    }
}

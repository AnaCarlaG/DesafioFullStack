using AutoMapper;
using Domain.Model;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Fornecedor, FornecedorViewModel>();
        }
    }
}

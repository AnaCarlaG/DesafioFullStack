using Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Fornecedor : EntidadeBase
    {
        public string CNPJ_CPF { get; set; }
        public string? RG { get; set; }
        public string? DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }

        public IList<Empresa> Empresas { get; set; }
    }
}

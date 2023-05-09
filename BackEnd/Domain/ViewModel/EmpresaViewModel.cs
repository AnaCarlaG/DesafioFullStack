using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class EmpresaViewModel
    {
        public long Id { get; set; }
        [Required]
        public string CNPJ_CPF { get; set; }
        public string? RG { get; set; }
        public string? DataNascimento { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CEP { get; set; }
        public List<FornecedorViewModel>? products { get; set; }
        
    }
}

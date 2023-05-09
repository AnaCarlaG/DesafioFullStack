using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class FornecedorViewModel
    {
        public long Id { get; set; }
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string CEP { get; set; }
    }
}

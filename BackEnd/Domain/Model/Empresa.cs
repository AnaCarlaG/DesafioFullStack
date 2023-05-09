using Domain.Model.Base;

namespace Domain.Model
{
    public class Empresa : EntidadeBase
    {
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string CEP { get; set; }

        public IList<Fornecedor> Fornecedor { get; set; }
    }
}
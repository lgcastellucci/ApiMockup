using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/confirma")]
        public RetornoConfirmaProposta ExecutaConfirma(ParametroConfirmaProposta Parametro)
        {
            var response = new RetornoConfirmaProposta();
            return response;
        }

        public class ParametroConfirmaPropostaEndereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
        }
        public class ParametroConfirmaProposta
        {
            public int CodOperadora { get; set; }
            public string ChaveIntegrador { get; set; }
            public int Proposta { get; set; }
            public string CPF { get; set; }
            public int VencimentoDia { get; set; }
            public int CodLocalEntrega { get; set; }
            public ParametroConfirmaPropostaEndereco Endereco { get; set; }
        }
        public class RetornoConfirmaProposta
        {
            public bool Sucesso { get; set; }
            public string MensagemTipo { get; set; }
            public string Mensagem { get; set; }
        }

    }
}

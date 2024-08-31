using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/inicia")]
        public RetornoIniciaProposta ExecutaInicia(ParametroIniciaProposta Parametro)
        {
            var response = new RetornoIniciaProposta();
            return response;
        }

        public class ParametroIniciaProposta
        {
            public int CodOperadora { get; set; }
            public string ChaveIntegrador { get; set; }
            public int CodEstabelecimento { get; set; }
            public string CPF { get; set; }
            public string Nascimento { get; set; }
            public string Celular { get; set; }
            public string Email { get; set; }
            public string CEP { get; set; }
            public string PromotorCPF { get; set; }
        }
        public class RetornoIniciaPropostaEndereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string UF { get; set; }
            public string Municipio { get; set; }
        }
        public class RetornoIniciaPropostaLocaisEntrega
        {
            public int CodLocalEntrega { get; set; }
            public string Descricao { get; set; }
            public float DistanciaKM { get; set; }
            public RetornoIniciaPropostaEndereco Endereco { get; set; }
        }
        public class RetornoIniciaProposta
        {
            public bool Sucesso { get; set; }
            public string MensagemTipo { get; set; }
            public string Mensagem { get; set; }
            public int Proposta { get; set; }
            public string Nome { get; set; }
            public int[] VencimentosDia { get; set; }
            public RetornoIniciaPropostaEndereco Endereco { get; set; }
            public RetornoIniciaPropostaLocaisEntrega[] LocaisEntrega { get; set; }
        }

    }

}

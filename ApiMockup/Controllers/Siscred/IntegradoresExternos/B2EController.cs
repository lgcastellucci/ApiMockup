using Microsoft.AspNetCore.Mvc;
namespace ApiMockup.Controllers.Siscred.IntegradoresExternos
{
    public partial class IntegradoresExternosController : ControllerBase
    {
        [HttpPost]
        [Route("b2e/api/Tokens")]
        /// <summary>
        /// Obtém o Token
        /// </summary>
        public RespostaTokens Tokens(RequisicaoTokens requisicao)
        {
            var response = new RespostaTokens();

            if (requisicao == null)
            {
                return response;
            }

            response.AccessToken = Guid.NewGuid().ToString();
            response.ExpiringAt = DateTime.Now.AddHours(3).ToString("dd.MM.yyyy HH:mm:ss");

            return response;
        }
        public class RequisicaoTokens
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            public RequisicaoTokens()
            {
                UserName = "";
                Password = "";
            }
        }
        public class RespostaTokens
        {
            public string AccessToken { get; set; }
            public string ExpiringAt { get; set; }

            public RespostaTokens()
            {
                AccessToken = "";
                ExpiringAt = "";
            }
        }


        [HttpPost]
        [Route("b2e/sincrono/v1.0.0/PropostasPessoaFisica")]
        /// <summary>
        /// Obtém o PropostasPessoaFisica
        /// </summary>
        public RespostaPropostasPessoaFisica PropostasPessoaFisica(RequisicaoPropostasPessoaFisica requisicao)
        {
            var response = new RespostaPropostasPessoaFisica();

            if (requisicao == null)
            {
                return response;
            }

            if (requisicao.DadosProponente == null)
            {
                return response;
            }

            if (string.IsNullOrEmpty(requisicao.DadosProponente.CPF))
            {
                return response;
            }

            if (requisicao.DadosProponente.CPF == "11122233396")
            {
                response.Sucesso = true;
                response.Mensagens = new List<RespostaPropostasPessoaFisica.Mensagem>();
                response.CodigoProposta = "10";
                response.PropostaId = "200000577973";
                response.PropostaProcessada = true;
                response.StatusProposta = new RespostaPropostasPessoaFisica.StsProposta();
                response.StatusProposta.Id = 12;
                response.StatusProposta.Nome = "RECUSADO AUTOMATICAMENTE";
                //response.StatusProposta.Descricao = null;
                response.Score = 0;
                //response.LimiteConcedido = null;
                //response.Alertas = null;
                response.InformacoesAdicionais = new List<RespostaPropostasPessoaFisica.InformacoesAdicionai>();
                var info = new RespostaPropostasPessoaFisica.InformacoesAdicionai();
                info.Grupo = "Parecer";
                info.Nome = "Regra Decisora";
                info.Valor = "SCORE ALTÍSSIMO RISCO";
                response.InformacoesAdicionais.Add(info);
            }
            else if (requisicao.DadosProponente.CPF == "22233344405")
            {
                response.Sucesso = true;
                response.Mensagens = new List<RespostaPropostasPessoaFisica.Mensagem>();
                response.CodigoProposta = "10";
                response.PropostaId = "200000577973";
                response.PropostaProcessada = true;
                response.StatusProposta = new RespostaPropostasPessoaFisica.StsProposta();
                response.StatusProposta.Id = 14;
                response.StatusProposta.Nome = "APROVADO AUTOMATICAMENTE";
                //response.StatusProposta.Descricao = null;
                response.Score = 0;
                //response.LimiteConcedido = null;
                //response.Alertas = null;
                response.InformacoesAdicionais = new List<RespostaPropostasPessoaFisica.InformacoesAdicionai>();
                var info = new RespostaPropostasPessoaFisica.InformacoesAdicionai();
                info.Grupo = "Parecer";
                info.Nome = "Regra Decisora";
                info.Valor = "SCORE SEM RISCO";
                response.InformacoesAdicionais.Add(info);
            }

            return response;
        }
        public class RequisicaoPropostasPessoaFisica
        {
            public string CodigoPropostaCliente { get; set; }
            public string CodigoInstituicao { get; set; }
            public Proponente DadosProponente { get; set; }
            public class Proponente
            {
                public string Nome { get; set; }
                public string CPF { get; set; }
                public string DataNascimento { get; set; }
                public string NomeMae { get; set; }
            }

        }
        public class RespostaPropostasPessoaFisica
        {
            public bool Sucesso { get; set; }
            public List<Mensagem> Mensagens { get; set; }
            public string CodigoProposta { get; set; }
            public string PropostaId { get; set; }
            public bool PropostaProcessada { get; set; }
            public StsProposta StatusProposta { get; set; }
            public double Score { get; set; }
            public object LimiteConcedido { get; set; }
            public object Alertas { get; set; }
            public List<InformacoesAdicionai> InformacoesAdicionais { get; set; }

            public class Mensagem
            {
                public string Codigo { get; set; }
                public string Descricao { get; set; }
            }
            public class StsProposta
            {
                public int Id { get; set; }
                public string Nome { get; set; }
                public object Descricao { get; set; }
            }
            public class InformacoesAdicionai
            {
                public string Grupo { get; set; }
                public string Nome { get; set; }
                public string Valor { get; set; }
            }
        }


    }
}

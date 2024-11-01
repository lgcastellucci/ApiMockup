using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiMockup.Controllers.Siscred.IntegradoresExternos
{
    public partial class IntegradoresExternosController : ControllerBase
    {
        [HttpPost]
        [Route("assertiva/oauth2/v3/token")]
        [Consumes("application/x-www-form-urlencoded")]
        public RespostaGetToken GetToken([FromForm] Dictionary<string, string> formData)
        {
            //https://api.assertivasolucoes.com.br/oauth2/v3/token-9999
            var response = new RespostaGetToken();

            if (formData.TryGetValue("grant_type", out var grantType) && grantType == "client_credentials")
            {
                // Lógica para gerar o token
                response.access_token = Guid.NewGuid().ToString();
                response.expires_in = "3600"; // segundos
            }
            else
            {
                response.error = "invalid_grant";
                response.error_description = "O tipo de concessão é inválido ou não suportado.";
            }

            return response;
        }
        public class RespostaGetToken
        {
            public string access_token { get; set; }
            public string expires_in { get; set; } //seconds
            public string error { get; set; }
            public string error_description { get; set; }
            public RespostaGetToken()
            {
                access_token = "";
                expires_in = "";
                error = "";
                error_description = "";
            }
        }


        [HttpPost]
        [Route("assertiva/autentica/v1/jornadas/pedidos")]
        public RespostaCriarPedido CriarPedido([FromBody] JsonElement jsonElement)
        {
            var response = new RespostaCriarPedido();

            response.success = true;
            response.status = "201";
            response.data.pedidoId = Guid.NewGuid().ToString();
            response.data.protocolo = Guid.NewGuid().ToString();

            return response;
        }
        public class RespostaCriarPedido
        {
            public bool success { get; set; }
            public string status { get; set; }
            public string messages { get; set; }
            public DetalhesCriarPedido data { get; set; }
            public class DetalhesCriarPedido
            {
                public string pedidoId { get; set; }
                public string protocolo { get; set; }
                public DetalhesCriarPedido()
                {
                    pedidoId = "";
                    protocolo = "";
                }
            }

            public RespostaCriarPedido()
            {
                success = false;
                status = "";
                messages = "";
                data = new DetalhesCriarPedido();
            }
        }


        [HttpGet]
        [Route("assertiva/autentica/v1/jornadas/partes/gerar-link")]
        /// <summary>
        /// Obtém o link para a jornada
        /// </summary>
        /// param name="protocolo">Protocolo do pedido</param>
        public RespostaObterLink ObterLink(string protocolo)
        {
            var response = new RespostaObterLink();

            response.success = true;
            response.status = "201";
            response.data.url = "http://seu.link.com.br/" + protocolo;

            return response;
        }
        public class RespostaObterLink
        {
            public bool success { get; set; }
            public string status { get; set; }
            public string messages { get; set; }
            public DetalhesObterLink data { get; set; }
            public class DetalhesObterLink
            {
                public string url { get; set; }
                public DetalhesObterLink()
                {
                    url = "";
                }
            }

            public RespostaObterLink()
            {
                success = false;
                status = "";
                messages = "";
                data = new DetalhesObterLink();
            }
        }


        [HttpGet]
        [Route("assertiva/autentica/v1/jornadas/partes/obter-partes-pedido")]
        /// <summary>
        /// Obtém partes para a jornada
        /// </summary>
        /// param name="pedidoID">Pedido ID</param>
        public RespostaObterPartes ObterPartes(string pedidoID)
        {
            var response = new RespostaObterPartes();

            response.success = true;
            response.status = "200";
            response.data.partes.Add(new RespostaObterPartes.Data.Parte() { id = Guid.NewGuid().ToString().Substring(0, 6), protocolo = Guid.NewGuid().ToString() });

            return response;
        }
        public class RespostaObterPartes
        {
            public bool success { get; set; }
            public string status { get; set; }
            public string messages { get; set; }
            public Data data { get; set; }
            public class Data
            {
                public List<Parte> partes { get; set; }
                public class Parte
                {
                    public string id { get; set; }
                    public string protocolo { get; set; }

                    public Parte()
                    {
                        id = "";
                        protocolo = "";
                    }
                }
                public Data()
                {
                    partes = new List<Parte>();
                }
            }

            public RespostaObterPartes()
            {
                success = false;
                status = "";
                messages = "";
                data = new Data();
            }
        }


        [HttpGet]
        [Route("assertiva/autentica/v1/jornadas/pedidos/detalhe")]
        /// <summary>
        /// Obtém o status da facial
        /// </summary>
        /// param name="pedidoID">Pedido ID</param>
        public RespostaVerificacaoFacial VerificacaoFacial(string pedidoID)
        {
            var response = new RespostaVerificacaoFacial();

            response.success = true;
            response.status = "200";
            //response.data.partes.Add(new RespostaVerificacaoFacial.Data.Parte() { id = Guid.NewGuid().ToString().Substring(0, 6), protocolo = Guid.NewGuid().ToString(),status = "APROVADO" });

            return response;
        }
        public class RespostaVerificacaoFacial
        {
            public bool success { get; set; }
            public string status { get; set; }
            public string messages { get; set; }
            public DataRespostaVerificacaoFacial data { get; set; }
            public class DataRespostaVerificacaoFacial
            {
                public List<ParteRespostaVerificacaoFacial> partes { get; set; }
                public class ParteRespostaVerificacaoFacial
                {
                    public string id { get; set; }
                    public string protocolo { get; set; }
                    public string status { get; set; }
                    public ParteRespostaVerificacaoFacial()
                    {
                        id = "";
                        protocolo = "";
                        status = "";
                    }
                }
                public DataRespostaVerificacaoFacial()
                {
                    partes = new List<ParteRespostaVerificacaoFacial>();
                }
            }

            public RespostaVerificacaoFacial()
            {
                success = false;
                status = "";
                messages = "";
                data = new DataRespostaVerificacaoFacial();
            }
        }
      

    }
}

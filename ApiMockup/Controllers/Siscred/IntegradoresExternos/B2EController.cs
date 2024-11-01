using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

            response.AccessToken = Guid.NewGuid().ToString();
            response.ExpiringAt =DateTime.Now.AddHours(3).ToString("dd.MM.yyyy HH:mm:ss");

            return response;
        }
        public class RequisicaoTokens
        {
            public string AccessToken { get; set; }
            public string ExpiringAt { get; set; }

            public RequisicaoTokens()
            {
                AccessToken = "";
                ExpiringAt = "";
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



    }
}

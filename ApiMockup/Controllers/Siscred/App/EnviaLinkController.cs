using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/enviaLink")]
        public RespostaEnviaLink ExecutaEnviaLink()
        {
            var response = new RespostaEnviaLink();
            return response;
        }

        public class RespostaEnviaLink
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaEnviaLink()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
            }
        }


    }
}

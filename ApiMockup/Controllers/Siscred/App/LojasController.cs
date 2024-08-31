using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/lojas")]
        public RespostaLojas ExecutaLojas()
        {
            var response = new RespostaLojas();
            return response;
        }

        public class RespostaLojas
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaLojas()
            {
                sucesso = false;
                mensagemCodigo = "9999-9999";
                mensagem = "";
            }
        }

    }

}


 
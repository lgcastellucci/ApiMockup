using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/configura")]
        public RespostaConfigura ExecutaConfigura()
        {
            var response = new RespostaConfigura();
            return response;
        }

        public class RespostaConfigura
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaConfigura()
            {
                sucesso = false;
                mensagemCodigo = "9999-9999";
                mensagem = "";
            }
        }

    }

}

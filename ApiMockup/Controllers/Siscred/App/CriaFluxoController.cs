using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/criarFluxo")]
        public RespostaCriaFluxo ExecutaCriaFluxo()
        {
            var response = new RespostaCriaFluxo();
            return response;
        }

        public class RespostaCriaFluxo
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaCriaFluxo()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
            }
        }


    }
}

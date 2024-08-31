using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/cep")]
        public RespostaCep ExecutaCep()
        {
            var response = new RespostaCep();
            return response;
        }

        public class RespostaCep
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaCep()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
            }
        }


    }
}

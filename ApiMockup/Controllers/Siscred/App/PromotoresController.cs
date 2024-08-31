using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/promotores")]
        public RespostaPromotores ExecutaPromotores()
        {
            var response = new RespostaPromotores();
            return response;
        }

        public class RespostaPromotores
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaPromotores()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
            }
        }


    }
}

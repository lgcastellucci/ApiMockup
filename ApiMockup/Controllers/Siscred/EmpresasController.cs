using Microsoft.AspNetCore.Mvc;
using static ApiMockup.Models.Empresas;

namespace ApiMockup.Controllers.ParceleDebitos.Integradores
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {

        // POST api/empresas
        [HttpPost]
        [Route("")]
        public Response ListarEmpresas()
        {
          var response = new Response();
           return response;
        }


    }
}

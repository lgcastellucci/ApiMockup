﻿using Microsoft.AspNetCore.Mvc;

namespace ApiMockup.Controllers.Siscred.App
{
    public partial class PrivateController : ControllerBase
    {
        [HttpPost]
        [Route("propostas/consulta")]
        public RespostaCorrige ExecutaCorrige()
        {
            var response = new RespostaCorrige();
            return response;
        }

        public class RespostaCorrige
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public RespostaCorrige()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
            }
        }


    }
}
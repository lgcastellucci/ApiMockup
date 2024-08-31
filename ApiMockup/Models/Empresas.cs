
namespace ApiMockup.Models
{
    public class Empresas
    {
        /// <summary>Response</summary>
        public class Response
        {
            public bool sucesso { get; set; }
            public string mensagem { get; set; }
            public string mensagemCodigo { get; set; }
            public List<ReponseDados> dados { get; set; }
            public Response()
            {
                sucesso = false;
                mensagemCodigo = "0014-9999";
                mensagem = "";
                dados = new List<ReponseDados>();
            }
        }
        public class ReponseDados
        {
            public string codigo { get; set; }
            public string cnpj { get; set; }
            public string razao { get; set; }
            public string fantasia { get; set; }
            public string financeiro { get; set; }
            public string bandeira { get; set; }
            public string status { get; set; }
            public string adesao { get; set; }
        }

    }
}
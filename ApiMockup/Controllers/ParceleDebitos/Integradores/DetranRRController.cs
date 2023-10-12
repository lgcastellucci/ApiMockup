using Microsoft.AspNetCore.Mvc;
using static ApiMockup.DetranRR;
using static ApiMockup.DetranRR.ConsultarVeiculoComDebitosResponse;

namespace ApiMockup.Controllers.ParceleDebitos.Integradores
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetranRRController : ControllerBase
    {

        // POST api/DetranRR/login
        [HttpPost]
        [Route("login")]
        public string Login(LoginRequest request)
        {
            // Gerando um novo GUID
            var novoGuid = Guid.NewGuid();

            // Convertendo para string (se necessário)
            return novoGuid.ToString();
        }

        // POST api/DetranRR/veiculo/ConsultarVeiculo
        [HttpPost]
        [Route("veiculo/ConsultarVeiculo")]
        public IActionResult ConsultarVeiculo(ConsultarVeiculoRequest request)
        {
            if (request == null)
                return BadRequest();

            if (request.placa == "AAA1234")
            {
                var dados = new ConsultarVeiculoResponse()
                {
                    codigo = 500,
                    placa = "AAA1234",
                    renavam = "123456789",
                    mensagem = "Erro no processamento"
                };

                return new JsonResult(dados);
            }
            else if (request.placa == "BBB1234")
            {
                var dados = new ConsultarVeiculoResponse()
                {
                    codigo = 404,
                    placa = "BBB1234",
                    renavam = "123456789",
                    mensagem = "Veículo não encontrado"
                };

                return new JsonResult(dados);
            }
            else if (request.placa == "CCC1234")
            {
                var dados = new ConsultarVeiculoComDebitosResponse()
                {
                    debitos = new Debitos()
                    {
                        ipva = new List<object>(),
                        licenciamento = new List<Licenciamento>(),
                        seguroObrigatorio = new List<object>(),
                    },
                    servicos = new Servicos()
                    {
                        servicos = new List<object>(),
                    },
                    infracoes = new Infracoes()
                    {
                        vencidas = new List<object>(),
                        avencer = new List<object>(),
                        emAutuacao = new List<object>(),
                    },
                    parcelamentoMultas = new ParcelamentoMultas()
                    {
                        parcelamentoMultas = new List<object>(),
                    },
                    placa = "CCC1234",
                    ufPlaca = "SP",
                    renavam = "123456789",
                    marca = "FERRARI",
                    cor = "VERMELHO",
                    nomeProprietario = "JOSE DA SILVA",
                    cpfCnpjProprietario = "12345678901",
                    restricaoAdministrativa = "",
                };

                return new JsonResult(dados);
            }
            else if (request.placa == "DDD1234")
            {
                var dados = new ConsultarVeiculoComDebitosResponse()
                {
                    debitos = new Debitos()
                    {
                        ipva = new List<object>(),
                        licenciamento = new List<Licenciamento> {
                            new Licenciamento
                            {
                                debitoId = "123456789",
                                orgaoAtuador = "DETRAN - RR",
                                ano = "2023",
                                dataVencimento = "31/10/2023",
                                dataValidade = "31/10/2023",
                                descricaoDebito = "Licenciamento Anual",
                                valor = "111,27",
                                valorCorrigido = "111,27",
                                valorDesconto = "0,00",
                                valorPago = "0,00",
                                valorDevido = "111,27",
                                codigoBarras = "856300000010112701772025310310110021226286520771"
                            }
                        },
                        seguroObrigatorio = new List<object>(),
                    },
                    servicos = new Servicos()
                    {
                        servicos = new List<object>(),
                    },
                    infracoes = new Infracoes()
                    {
                        vencidas = new List<object>(),
                        avencer = new List<object>(),
                        emAutuacao = new List<object>(),
                    },
                    parcelamentoMultas = new ParcelamentoMultas()
                    {
                        parcelamentoMultas = new List<object>(),
                    },
                    placa = "CCC1234",
                    ufPlaca = "SP",
                    renavam = "123456789",
                    marca = "FERRARI",
                    cor = "VERMELHO",
                    nomeProprietario = "JOSE DA SILVA",
                    cpfCnpjProprietario = "12345678901",
                    restricaoAdministrativa = "",
                };

                return new JsonResult(dados);

            }

            return BadRequest();
        }


    }
}

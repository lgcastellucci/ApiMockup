using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static ApiMockup.DetranRR;
using static ApiMockup.DetranRR.ConsultarVeiculoComDebitosResponse;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                        vencidas = new List<Infracao>(),
                        avencer = new List<Infracao>(),
                        emAutuacao = new List<Infracao>(),
                    },
                    parcelamentoMultas = new ParcelamentoMultas()
                    {
                        parcelamentoMultas = new List<object>(),
                    },
                    placa = "CCC1234",
                    ufPlaca = "SP",
                    renavam = "123456789",
                    marca = "UNO",
                    cor = "VERMELHO",
                    nomeProprietario = "JOSE DA SILVA",
                    cpfCnpjProprietario = "12345678901",
                    restricaoAdministrativa = "",
                };

                return new JsonResult(dados);
            }
            else if (request.placa == "DDD1234")
            {
                var uteis = new Uteis();

                var dados = new ConsultarVeiculoComDebitosResponse()
                {
                    debitos = new Debitos()
                    {
                        ipva = new List<object>(),
                        licenciamento = new List<Licenciamento> {
                            new Licenciamento
                            {
                                  debitoId =  "1111111111",
                                  orgaoAtuador = "DETRAN - RR",
                                  ano = DateTime.Now.AddYears(-1).Year.ToString(),
                                  dataVencimento= uteis.UltimoDiaDoMes(DateTime.Now.AddYears(-1)).ToString("dd/MM/yyyy"),
                                  dataValidade= uteis.UltimoDiaDoMes().ToString("dd/MM/yyyy"),
                                  descricaoDebito= "Licenciamento Anual",
                                  valor= "142,18",
                                  valorCorrigido= "142,18",
                                  valorDesconto= "0,00",
                                  valorPago="0,00",
                                  valorDevido= "142,18",
                                  codigoBarras= "856600000017421801772029310310110021209870510770"
                            },
                            new Licenciamento
                            {
                                debitoId = "2222222222",
                                orgaoAtuador = "DETRAN - RR",
                                ano = DateTime.Now.Year.ToString(),
                                dataVencimento = uteis.UltimoDiaDoMes().ToString("dd/MM/yyyy"),
                                dataValidade = uteis.UltimoDiaDoMes().ToString("dd/MM/yyyy"),
                                descricaoDebito = "Licenciamento Anual",
                                valor = "111,27",
                                valorCorrigido = "111,27",
                                valorDesconto = "0,00",
                                valorPago = "0,00",
                                valorDevido = "111,27",
                                codigoBarras = "85630000001011270177202531031011002122628652071"
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
                        vencidas = new List<Infracao> {
                            new Infracao
                            {
                                debitoId= "99100223575255",
                                orgaoAtuador= "PREFEITURA MUNICIPAL DE BOA VISTA - RR",
                                ano= "0",
                                dataVencimento= "02/05/2018",
                                dataValidade= "31/10/2023",
                                descricaoDebito= "Dirigir usando uma das maos",
                                valor= "293,47",
                                valorCorrigido= "407,07",
                                valorDesconto= "0,00",
                                valorPago= "0,00",
                                valorDevido= "407,07",
                                codigoBarras= "856200000045070701772025310319910025235752553000",
                                numeroAuto= "M149416597 - 01",
                                codigoInfracao= "07633 - DIRIGIR VEÍCULO MANUSEANDO TELEFONE CELULAR"
                             },
                             new Infracao
                             {
                                debitoId= "99100223575352",
                                orgaoAtuador= "PREFEITURA MUNICIPAL DE BOA VISTA - RR",
                                ano= "0",
                                dataVencimento= "02/05/2018",
                                dataValidade= "31/10/2023",
                                descricaoDebito= "Dirigir usando uma das maos",
                                valor= "293,47",
                                valorCorrigido= "407,07",
                                valorDesconto= "0,00",
                                valorPago= "0,00",
                                valorDevido= "407,07",
                                codigoBarras= "856400000043070701772025310319910025235753523002",
                                numeroAuto= "M149416569 - 01",
                                codigoInfracao= "07633 - DIRIGIR VEÍCULO MANUSEANDO TELEFONE CELULAR"
                             }
                        },
                        avencer = new List<Infracao>(),
                        emAutuacao = new List<Infracao> {
                            new Infracao
                            {
                                debitoId= "99100223575450",
                                orgaoAtuador= "PREFEITURA MUNICIPAL DE BOA VISTA - RR",
                                ano= "0",
                                dataVencimento= "16/10/2023",
                                dataValidade= "16/10/2023",
                                descricaoDebito= "Avanco de sinal",
                                valor= "293,47",
                                valorCorrigido= "293,47",
                                valorDesconto= "234,78",
                                valorPago= "0,00",
                                valorDevido= "234,78",
                                codigoBarras= "856700000024347801772026310169910026235754503003",
                                numeroAuto= "T000019113 - 01",
                                codigoInfracao= "06050 - AVANÇAR O SINAL VERMELHO SEMÁF FISC ELETRÔNICA"
                             },
                             new Infracao
                             {
                                debitoId= "99100223575557",
                                orgaoAtuador= "PREFEITURA MUNICIPAL DE BOA VISTA - RR",
                                ano= "0",
                                dataVencimento= "16/10/2023",
                                dataValidade= "16/10/2023",
                                descricaoDebito= "Por excesso de velocidade",
                                valor= "130,16",
                                valorCorrigido= "130,16",
                                valorDesconto= "104,13",
                                valorPago= "0,00",
                                valorDevido= "104,13",
                                codigoBarras= "856400000019041301772020310169910026235755573005",
                                numeroAuto= "R000078511 - 01",
                                codigoInfracao= "07455 - TRANS EM VELO SUP MAX PERMITIDA EM ATÉ 20%"
                             }
                        },
                    },
                    parcelamentoMultas = new ParcelamentoMultas()
                    {
                        parcelamentoMultas = new List<object>(),
                    },
                    placa = "CCC1234",
                    ufPlaca = "SP",
                    renavam = "123456789",
                    marca = "UNO",
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

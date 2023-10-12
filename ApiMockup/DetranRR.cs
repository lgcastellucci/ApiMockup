using System.Numerics;

namespace ApiMockup
{
    public class DetranRR
    {
        public class LoginRequest
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class ConsultarVeiculoRequest
        {
            public string placa { get; set; }
            public string renavam { get; set; }
        }

        public class ConsultarVeiculoResponse
        {
            public int codigo { get; set; }
            public string placa { get; set; }
            public string renavam { get; set; }
            public string mensagem { get; set; }
        }

        public class ConsultarVeiculoComDebitosResponse
        {
            public Debitos debitos { get; set; }
            public Servicos servicos { get; set; }
            public Infracoes infracoes { get; set; }
            public ParcelamentoMultas parcelamentoMultas { get; set; }
            public string placa { get; set; }
            public string ufPlaca { get; set; }
            public string renavam { get; set; }
            public string marca { get; set; }
            public string cor { get; set; }
            public string nomeProprietario { get; set; }
            public string cpfCnpjProprietario { get; set; }
            public string restricaoAdministrativa { get; set; }

            public class Debitos
            {
                public List<object> ipva { get; set; }
                public List<Licenciamento> licenciamento { get; set; }
                public List<object> seguroObrigatorio { get; set; }
            }

            public class Infracoes
            {
                public List<object> vencidas { get; set; }
                public List<object> avencer { get; set; }
                public List<object> emAutuacao { get; set; }
            }

            public class Licenciamento
            {
                public string debitoId { get; set; }
                public string orgaoAtuador { get; set; }
                public string ano { get; set; }
                public string dataVencimento { get; set; }
                public string dataValidade { get; set; }
                public string descricaoDebito { get; set; }
                public string valor { get; set; }
                public string valorCorrigido { get; set; }
                public string valorDesconto { get; set; }
                public string valorPago { get; set; }
                public string valorDevido { get; set; }
                public string codigoBarras { get; set; }
            }

            public class ParcelamentoMultas
            {
                public List<object> parcelamentoMultas { get; set; }
            }

            public class Servicos
            {
                public List<object> servicos { get; set; }
            }

        }


    }
}
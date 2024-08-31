using System.Xml.Serialization;

namespace ApiMockup.Models
{
    public static class IntegradorExternoSCPC
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(SPCAXML));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (SPCAXML)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "S-ACERTA-PRODUTO")]
        public class SACERTAPRODUTO
        {

            [XmlElement(ElementName = "S-ACERTA-SCORE")]
            public string? SACERTASCORE { get; set; }

            [XmlElement(ElementName = "S-ACERTA-SCORE-MODELO")]
            public string? SACERTASCOREMODELO { get; set; }

            [XmlElement(ElementName = "S-ACERTA-CHEQUE")]
            public string? SACERTACHEQUE { get; set; }
        }

        [XmlRoot(ElementName = "SOLICITACAO")]
        public class SOLICITACAO
        {

            [XmlElement(ElementName = "S-REGIONAL")]
            public int? SREGIONAL { get; set; }

            [XmlElement(ElementName = "S-CODIGO")]
            public int? SCODIGO { get; set; }

            [XmlElement(ElementName = "S-CONSULTA")]
            public int? SCONSULTA { get; set; }

            [XmlElement(ElementName = "S-SOLICITANTE")]
            public string? SSOLICITANTE { get; set; }

            [XmlElement(ElementName = "S-CPF")]
            public double? SCPF { get; set; }

            [XmlElement(ElementName = "S-DDD-1")]
            public int? SDDD1 { get; set; }

            [XmlElement(ElementName = "S-TELEFONE-1")]
            public int? STELEFONE1 { get; set; }

            [XmlElement(ElementName = "S-CEP")]
            public int? SCEP { get; set; }

            [XmlElement(ElementName = "S-ACERTA-PRODUTO")]
            public SACERTAPRODUTO? SACERTAPRODUTO { get; set; }

            [XmlElement(ElementName = "S-CHEQUE-ORIGEM")]
            public string? SCHEQUEORIGEM { get; set; }

            [XmlElement(ElementName = "S-CHEQUE-DATA")]
            public int? SCHEQUEDATA { get; set; }

            [XmlElement(ElementName = "S-CHEQUE-QTDE")]
            public int? SCHEQUEQTDE { get; set; }

            [XmlElement(ElementName = "S-BANCO")]
            public int? SBANCO { get; set; }

            [XmlElement(ElementName = "S-AGENCIA")]
            public int? SAGENCIA { get; set; }

            [XmlElement(ElementName = "S-CONTA-CORRENTE")]
            public int? SCONTACORRENTE { get; set; }

            [XmlElement(ElementName = "S-CONTA-DIGITO")]
            public int? SCONTADIGITO { get; set; }

            [XmlElement(ElementName = "S-CHEQUE")]
            public int? SCHEQUE { get; set; }

            [XmlElement(ElementName = "S-CHEQUE-DIGITO")]
            public int? SCHEQUEDIGITO { get; set; }

            [XmlElement(ElementName = "S-CMC7")]
            public string? SCMC7 { get; set; }

            [XmlElement(ElementName = "S-TIPO-CREDITO")]
            public string? STIPOCREDITO { get; set; }

            [XmlElement(ElementName = "S-NUMERO-RESPOSTA")]
            public int? SNUMERORESPOSTA { get; set; }
        }

        [XmlRoot(ElementName = "RESPOSTA-RETORNO")]
        public class RESPOSTARETORNO
        {

            [XmlElement(ElementName = "STATUS-RESPOSTA")]
            public int? STATUSRESPOSTA { get; set; }

            [XmlElement(ElementName = "MENSAGEM-RESPOSTA")]
            public string? MENSAGEMRESPOSTA { get; set; }
        }

        [XmlRoot(ElementName = "RESUMO-DE-ACOES-CIVEIS")]
        public class RESUMODEACOESCIVEIS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "RELACAO-DE-ACOES-CIVEIS")]
        public class RELACAODEACOESCIVEIS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "RESUMO-OCORRENCIAS-DE-DEBITOS")]
        public class RESUMOOCORRENCIASDEDEBITOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "INFORMACOES-COMPLEMENTARES")]
        public class INFORMACOESCOMPLEMENTARES
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "DEBITOS")]
        public class DEBITOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "TITULOS-PROTESTADOS")]
        public class TITULOSPROTESTADOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "RESUMO-TITULOS-PROTESTADOS")]
        public class RESUMOTITULOSPROTESTADOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "CONFIRMACAO-TELEFONE")]
        public class CONFIRMACAOTELEFONE
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "NOME-DOCUMENTOS")]
        public class NOMEDOCUMENTOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "PARTICIPACOES-DO-DOCUMENTO-CONSULTADO")]
        public class PARTICIPACOESDODOCUMENTOCONSULTADO
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "RELACAO-FALENCIA-RECUPERACAO-JUDICIAL")]
        public class RELACAOFALENCIARECUPERACAOJUDICIAL
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "IDENTIFICACAO")]
        public class IDENTIFICACAO
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }

            [XmlElement(ElementName = "DOCUMENTO")]
            public double? DOCUMENTO { get; set; }

            [XmlElement(ElementName = "NOME")]
            public string? NOME { get; set; }

            [XmlElement(ElementName = "NOMEMAE")]
            public string? NOMEMAE { get; set; }

            [XmlElement(ElementName = "DATANASCIMENTO")]
            public string? DATANASCIMENTO { get; set; }

            [XmlElement(ElementName = "DATAEMISSAORG")]
            public string? DATAEMISSAORG { get; set; }

            [XmlElement(ElementName = "SEXOCONSULTADO")]
            public int? SEXOCONSULTADO { get; set; }

            [XmlElement(ElementName = "CIDADENASCIMENTO")]
            public string? CIDADENASCIMENTO { get; set; }

            [XmlElement(ElementName = "ESTADOCIVIL")]
            public int? ESTADOCIVIL { get; set; }

            [XmlElement(ElementName = "NUMERODEPENDENTES")]
            public int? NUMERODEPENDENTES { get; set; }

            [XmlElement(ElementName = "GRAUINSTRUCAO")]
            public int? GRAUINSTRUCAO { get; set; }

            [XmlElement(ElementName = "SITUACAORECEITA")]
            public int? SITUACAORECEITA { get; set; }

            [XmlElement(ElementName = "DATAATUALIZACAO")]
            public string? DATAATUALIZACAO { get; set; }

            [XmlElement(ElementName = "REGIAOCPF")]
            public int? REGIAOCPF { get; set; }

            [XmlElement(ElementName = "TITULOELEITOR")]
            public double? TITULOELEITOR { get; set; }
        }

        [XmlRoot(ElementName = "LOCALIZACAO")]
        public class LOCALIZACAO
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOLOGRADOURO")]
            public string? TIPOLOGRADOURO { get; set; }

            [XmlElement(ElementName = "NOMELOGRADOURO")]
            public string? NOMELOGRADOURO { get; set; }

            [XmlElement(ElementName = "NUMEROLOGRADOURO")]
            public int? NUMEROLOGRADOURO { get; set; }

            [XmlElement(ElementName = "COMPLEMENTO")]
            public string? COMPLEMENTO { get; set; }

            [XmlElement(ElementName = "BAIRRO")]
            public string? BAIRRO { get; set; }

            [XmlElement(ElementName = "CIDADE")]
            public string? CIDADE { get; set; }

            [XmlElement(ElementName = "UNIDADEFEDERATIVA")]
            public string? UNIDADEFEDERATIVA { get; set; }

            [XmlElement(ElementName = "CEP")]
            public int? CEP { get; set; }

            [XmlElement(ElementName = "DDD-1")]
            public int? DDD1 { get; set; }

            [XmlElement(ElementName = "TELEFONE-1")]
            public int? TELEFONE1 { get; set; }

            [XmlElement(ElementName = "DDD-2")]
            public int? DDD2 { get; set; }

            [XmlElement(ElementName = "TELEFONE-2")]
            public int? TELEFONE2 { get; set; }

            [XmlElement(ElementName = "DDD-3")]
            public int? DDD3 { get; set; }

            [XmlElement(ElementName = "TELEFONE-3")]
            public int? TELEFONE3 { get; set; }
        }

        [XmlRoot(ElementName = "SCORE-CLASSIFICACAO-VARIOS-MODELOS")]
        public class SCORECLASSIFICACAOVARIOSMODELOS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOSCORE")]
            public int? TIPOSCORE { get; set; }

            [XmlElement(ElementName = "SCORE")]
            public int? SCORE { get; set; }

            [XmlElement(ElementName = "VALOR")]
            public int? VALOR { get; set; }

            [XmlElement(ElementName = "PLANOEXECUCAO")]
            public string? PLANOEXECUCAO { get; set; }

            [XmlElement(ElementName = "MODELOSCORE")]
            public string? MODELOSCORE { get; set; }

            [XmlElement(ElementName = "NOMESCORE")]
            public string? NOMESCORE { get; set; }

            [XmlElement(ElementName = "CLASSIFICACAONUMERICA")]
            public int? CLASSIFICACAONUMERICA { get; set; }

            [XmlElement(ElementName = "CLASSIFICACAOALFABETICA")]
            public string? CLASSIFICACAOALFABETICA { get; set; }

            [XmlElement(ElementName = "PROBABILIDADE")]
            public int? PROBABILIDADE { get; set; }

            [XmlElement(ElementName = "TEXTO")]
            public string? TEXTO { get; set; }

            [XmlElement(ElementName = "CODIGONATUREZAMODELO")]
            public int? CODIGONATUREZAMODELO { get; set; }

            [XmlElement(ElementName = "DESCRICAONATUREZA")]
            public string? DESCRICAONATUREZA { get; set; }

            [XmlElement(ElementName = "MODELOPLANO")]
            public string? MODELOPLANO { get; set; }

            [XmlElement(ElementName = "TEXTO2")]
            public string? TEXTO2 { get; set; }
        }

        [XmlRoot(ElementName = "NOTA-COMPORTAMENTO-FATURA-EM-ATRASO")]
        public class NOTACOMPORTAMENTOFATURAEMATRASO
        {

            [XmlElement(ElementName = "NOTA")]
            public string? NOTA { get; set; }
        }

        [XmlRoot(ElementName = "NOTA-COMPORTAMENTO-CONTRATOS-RECENTES")]
        public class NOTACOMPORTAMENTOCONTRATOSRECENTES
        {

            [XmlElement(ElementName = "NOTA")]
            public string? NOTA { get; set; }
        }

        [XmlRoot(ElementName = "PAINEL-CONTROLE-POSITIVO")]
        public class PAINELCONTROLEPOSITIVO
        {

            [XmlElement(ElementName = "NOTA-COMPORTAMENTO-FATURA-EM-ATRASO")]
            public NOTACOMPORTAMENTOFATURAEMATRASO? NOTACOMPORTAMENTOFATURAEMATRASO { get; set; }

            [XmlElement(ElementName = "NOTA-COMPORTAMENTO-CONTRATOS-RECENTES")]
            public NOTACOMPORTAMENTOCONTRATOSRECENTES? NOTACOMPORTAMENTOCONTRATOSRECENTES { get; set; }
        }

        [XmlRoot(ElementName = "MENSAGEM-REGISTRO")]
        public class MENSAGEMREGISTRO
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "STATUS-CONSUMIDOR")]
        public class STATUSCONSUMIDOR
        {

            [XmlElement(ElementName = "MENSAGEM")]
            public string? MENSAGEM { get; set; }
        }

        [XmlRoot(ElementName = "RESUMOCONSULTAS-ANTERIORES-90-DIAS")]
        public class RESUMOCONSULTASANTERIORES90DIAS
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "CONSULTAS-ANTERIORES")]
        public class CONSULTASANTERIORES
        {

            [XmlElement(ElementName = "TAMANHOREGISTRO")]
            public int? TAMANHOREGISTRO { get; set; }

            [XmlElement(ElementName = "TIPOREGISTRO")]
            public int? TIPOREGISTRO { get; set; }

            [XmlElement(ElementName = "REGISTRO")]
            public string? REGISTRO { get; set; }
        }

        [XmlRoot(ElementName = "ACERTA")]
        public class ACERTA
        {

            [XmlElement(ElementName = "RESUMO-DE-ACOES-CIVEIS")]
            public RESUMODEACOESCIVEIS? RESUMODEACOESCIVEIS { get; set; }

            [XmlElement(ElementName = "RELACAO-DE-ACOES-CIVEIS")]
            public RELACAODEACOESCIVEIS? RELACAODEACOESCIVEIS { get; set; }

            [XmlElement(ElementName = "RESUMO-OCORRENCIAS-DE-DEBITOS")]
            public RESUMOOCORRENCIASDEDEBITOS? RESUMOOCORRENCIASDEDEBITOS { get; set; }

            [XmlElement(ElementName = "INFORMACOES-COMPLEMENTARES")]
            public INFORMACOESCOMPLEMENTARES? INFORMACOESCOMPLEMENTARES { get; set; }

            [XmlElement(ElementName = "DEBITOS")]
            public DEBITOS? DEBITOS { get; set; }

            [XmlElement(ElementName = "TITULOS-PROTESTADOS")]
            public TITULOSPROTESTADOS? TITULOSPROTESTADOS { get; set; }

            [XmlElement(ElementName = "RESUMO-TITULOS-PROTESTADOS")]
            public RESUMOTITULOSPROTESTADOS? RESUMOTITULOSPROTESTADOS { get; set; }

            [XmlElement(ElementName = "CONFIRMACAO-TELEFONE")]
            public CONFIRMACAOTELEFONE? CONFIRMACAOTELEFONE { get; set; }

            [XmlElement(ElementName = "NOME-DOCUMENTOS")]
            public NOMEDOCUMENTOS? NOMEDOCUMENTOS { get; set; }

            [XmlElement(ElementName = "PARTICIPACOES-DO-DOCUMENTO-CONSULTADO")]
            public PARTICIPACOESDODOCUMENTOCONSULTADO? PARTICIPACOESDODOCUMENTOCONSULTADO { get; set; }

            [XmlElement(ElementName = "RELACAO-FALENCIA-RECUPERACAO-JUDICIAL")]
            public RELACAOFALENCIARECUPERACAOJUDICIAL? RELACAOFALENCIARECUPERACAOJUDICIAL { get; set; }

            [XmlElement(ElementName = "IDENTIFICACAO")]
            public IDENTIFICACAO? IDENTIFICACAO { get; set; }

            [XmlElement(ElementName = "LOCALIZACAO")]
            public LOCALIZACAO? LOCALIZACAO { get; set; }

            [XmlElement(ElementName = "SCORE-CLASSIFICACAO-VARIOS-MODELOS")]
            public List<SCORECLASSIFICACAOVARIOSMODELOS>? SCORECLASSIFICACAOVARIOSMODELOS { get; set; }

            [XmlElement(ElementName = "PAINEL-CONTROLE-POSITIVO")]
            public PAINELCONTROLEPOSITIVO? PAINELCONTROLEPOSITIVO { get; set; }

            [XmlElement(ElementName = "MENSAGEM-REGISTRO")]
            public MENSAGEMREGISTRO? MENSAGEMREGISTRO { get; set; }

            [XmlElement(ElementName = "STATUS-CONSUMIDOR")]
            public STATUSCONSUMIDOR? STATUSCONSUMIDOR { get; set; }

            [XmlElement(ElementName = "RESUMOCONSULTAS-ANTERIORES-90-DIAS")]
            public RESUMOCONSULTASANTERIORES90DIAS? RESUMOCONSULTASANTERIORES90DIAS { get; set; }

            [XmlElement(ElementName = "CONSULTAS-ANTERIORES")]
            public CONSULTASANTERIORES? CONSULTASANTERIORES { get; set; }
        }

        [XmlRoot(ElementName = "RESPOSTA")]
        public class RESPOSTA
        {

            [XmlElement(ElementName = "RESPOSTA-RETORNO")]
            public RESPOSTARETORNO? RESPOSTARETORNO { get; set; }

            [XmlElement(ElementName = "NUMERO-RESPOSTA")]
            public string? NUMERORESPOSTA { get; set; }

            [XmlElement(ElementName = "ASSOCIADO-SOLICITANTE")]
            public string? ASSOCIADOSOLICITANTE { get; set; }

            [XmlElement(ElementName = "NOME-CONSULTA")]
            public string? NOMECONSULTA { get; set; }

            [XmlElement(ElementName = "IP-SOLICITANTE")]
            public string? IPSOLICITANTE { get; set; }

            [XmlElement(ElementName = "ACERTA")]
            public ACERTA? ACERTA { get; set; }
        }

        [XmlRoot(ElementName = "SPCA-XML")]
        public class SPCAXML
        {

            [XmlElement(ElementName = "VERSAO")]
            public int? VERSAO { get; set; }

            [XmlElement(ElementName = "SOLICITACAO")]
            public SOLICITACAO? SOLICITACAO { get; set; }

            [XmlElement(ElementName = "RESPOSTA")]
            public RESPOSTA? RESPOSTA { get; set; }

            [XmlAttribute(AttributeName = "xsi")]
            public string? Xsi { get; set; }

            [XmlAttribute(AttributeName = "noNamespaceSchemaLocation")]
            public string? NoNamespaceSchemaLocation { get; set; }

            [XmlText]
            public string? Text { get; set; }
        }


    }
}

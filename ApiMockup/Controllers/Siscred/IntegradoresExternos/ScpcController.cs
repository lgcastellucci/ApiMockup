﻿using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using static ApiMockup.Models.IntegradorExternoSCPC;

namespace ApiMockup.Controllers.Siscred.IntegradoresExternos
{
    public partial class IntegradoresExternosController : ControllerBase
    {
        [HttpPost]
        [Route("scpc")]
        [Consumes("text/xml")] // Define que o método consome XML
        [Produces("text/xml")] // Define que o método produz XML
        public SPCAXML ExecutaSCPC(SPCAXML parametro)
        {
            var response = new SPCAXML();
            var resposta = "";

            if (parametro.SOLICITACAO.SCPF == "11122233396")
            {
                resposta += "<?xml version=\"1.0\" encoding=\"ISO - 8859 - 1\"?>";
                resposta += "<SPCA-XML xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"https://www.scpc.inf.br/spcn/spcaxmlacerta.xsd\">";
                resposta += "	<VERSAO>20090415</VERSAO>";
                resposta += "	<SOLICITACAO>";
                resposta += "		<S-REGIONAL>0</S-REGIONAL>";
                resposta += "		<S-CODIGO>150</S-CODIGO>";
                resposta += "		<S-CONSULTA>353</S-CONSULTA>";
                resposta += "		<S-SOLICITANTE/>";
                resposta += "		<S-CPF>" + parametro.SOLICITACAO.SCPF + "</S-CPF>";
                resposta += "		<S-DDD-1>19</S-DDD-1>";
                resposta += "		<S-TELEFONE-1>99990000</S-TELEFONE-1>";
                resposta += "		<S-CEP>0</S-CEP>";
                resposta += "		<S-ACERTA-PRODUTO>";
                resposta += "			<S-ACERTA-SCORE>N</S-ACERTA-SCORE>";
                resposta += "			<S-ACERTA-SCORE-MODELO/>";
                resposta += "			<S-ACERTA-CHEQUE>N</S-ACERTA-CHEQUE>";
                resposta += "		</S-ACERTA-PRODUTO>";
                resposta += "		<S-CHEQUE-ORIGEM/>";
                resposta += "		<S-CHEQUE-DATA>0</S-CHEQUE-DATA>";
                resposta += "		<S-CHEQUE-QTDE>0</S-CHEQUE-QTDE>";
                resposta += "		<S-BANCO>0</S-BANCO>";
                resposta += "		<S-AGENCIA>0</S-AGENCIA>";
                resposta += "		<S-CONTA-CORRENTE>0</S-CONTA-CORRENTE>";
                resposta += "		<S-CONTA-DIGITO>0</S-CONTA-DIGITO>";
                resposta += "		<S-CHEQUE>0</S-CHEQUE>";
                resposta += "		<S-CHEQUE-DIGITO>0</S-CHEQUE-DIGITO>";
                resposta += "		<S-CMC7/>";
                resposta += "		<S-TIPO-CREDITO>OU</S-TIPO-CREDITO>";
                resposta += "		<S-NUMERO-RESPOSTA>0</S-NUMERO-RESPOSTA>";
                resposta += "	</SOLICITACAO>";
                resposta += "	<RESPOSTA>";
                resposta += "		<RESPOSTA-RETORNO>";
                resposta += "			<STATUS-RESPOSTA>0</STATUS-RESPOSTA>";
                resposta += "			<MENSAGEM-RESPOSTA>CONSULTA CONCLUIDA</MENSAGEM-RESPOSTA>";
                resposta += "		</RESPOSTA-RETORNO>";
                resposta += "		<NUMERO-RESPOSTA>123123123-0</NUMERO-RESPOSTA>";
                resposta += "		<ASSOCIADO-SOLICITANTE>DROGAL FARMACEUTICA</ASSOCIADO-SOLICITANTE>";
                resposta += "		<NOME-CONSULTA>ACERTA ESSENCIAL POSITIVO</NOME-CONSULTA>";
                resposta += "		<IP-SOLICITANTE>123.123.123.123</IP-SOLICITANTE>";
                resposta += "		<ACERTA>";
                resposta += "			<RESUMO-DE-ACOES-CIVEIS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>020</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMO-DE-ACOES-CIVEIS>";
                resposta += "			<RELACAO-DE-ACOES-CIVEIS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>021</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RELACAO-DE-ACOES-CIVEIS>";
                resposta += "			<RESUMO-OCORRENCIAS-DE-DEBITOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>108</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMO-OCORRENCIAS-DE-DEBITOS>";
                resposta += "			<INFORMACOES-COMPLEMENTARES>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>123</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</INFORMACOES-COMPLEMENTARES>";
                resposta += "			<DEBITOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>124</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</DEBITOS>";
                resposta += "			<TITULOS-PROTESTADOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>142</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</TITULOS-PROTESTADOS>";
                resposta += "			<RESUMO-TITULOS-PROTESTADOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>146</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMO-TITULOS-PROTESTADOS>";
                resposta += "			<CONFIRMACAO-TELEFONE>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>223</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</CONFIRMACAO-TELEFONE>";
                resposta += "			<NOME-DOCUMENTOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>241</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</NOME-DOCUMENTOS>";
                resposta += "			<PARTICIPACOES-DO-DOCUMENTO-CONSULTADO>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>282</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</PARTICIPACOES-DO-DOCUMENTO-CONSULTADO>";
                resposta += "			<RELACAO-FALENCIA-RECUPERACAO-JUDICIAL>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>295</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RELACAO-FALENCIA-RECUPERACAO-JUDICIAL>";
                resposta += "			<IDENTIFICACAO>";
                resposta += "				<TAMANHOREGISTRO>366</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>500</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<DOCUMENTO>" + parametro.SOLICITACAO.SCPF + "</DOCUMENTO>";
                resposta += "				<NOME>LUIS SOUZA</NOME>";
                resposta += "				<NOMEMAE>MARIA SOUZA</NOMEMAE>";
                resposta += "				<DATANASCIMENTO>01/01/1980</DATANASCIMENTO>";
                resposta += "				<DATAEMISSAORG>-</DATAEMISSAORG>";
                resposta += "				<SEXOCONSULTADO>1</SEXOCONSULTADO>";
                resposta += "				<CIDADENASCIMENTO>BRASILEIRO</CIDADENASCIMENTO>";
                resposta += "				<ESTADOCIVIL>0</ESTADOCIVIL>";
                resposta += "				<NUMERODEPENDENTES>0</NUMERODEPENDENTES>";
                resposta += "				<GRAUINSTRUCAO>6</GRAUINSTRUCAO>";
                resposta += "				<SITUACAORECEITA>1</SITUACAORECEITA>";
                resposta += "				<DATAATUALIZACAO>01/08/2024</DATAATUALIZACAO>";
                resposta += "				<REGIAOCPF>8</REGIAOCPF>";
                resposta += "				<TITULOELEITOR>1234567890123</TITULOELEITOR>";
                resposta += "			</IDENTIFICACAO>";
                resposta += "			<LOCALIZACAO>";
                resposta += "				<TAMANHOREGISTRO>323</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>501</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOLOGRADOURO>AV</TIPOLOGRADOURO>";
                resposta += "				<NOMELOGRADOURO>INDEPENDENCIA</NOMELOGRADOURO>";
                resposta += "				<NUMEROLOGRADOURO>123</NUMEROLOGRADOURO>";
                resposta += "				<COMPLEMENTO/>";
                resposta += "				<BAIRRO>CENTRO</BAIRRO>";
                resposta += "				<CIDADE>PIRACICABA</CIDADE>";
                resposta += "				<UNIDADEFEDERATIVA>SP</UNIDADEFEDERATIVA>";
                resposta += "				<CEP>13405000</CEP>";
                resposta += "				<DDD-1>0019</DDD-1>";
                resposta += "				<TELEFONE-1>912341234</TELEFONE-1>";
                resposta += "				<DDD-2>0019</DDD-2>";
                resposta += "				<TELEFONE-2>12345678</TELEFONE-2>";
                resposta += "				<DDD-3>0019</DDD-3>";
                resposta += "				<TELEFONE-3>12345678</TELEFONE-3>";
                resposta += "			</LOCALIZACAO>";
                resposta += "			<SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "				<TAMANHOREGISTRO>462</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>601</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOSCORE>1</TIPOSCORE>";
                resposta += "				<SCORE>721</SCORE>";
                resposta += "				<VALOR>0</VALOR>";
                resposta += "				<PLANOEXECUCAO>N</PLANOEXECUCAO>";
                resposta += "				<MODELOSCORE>1D</MODELOSCORE>";
                resposta += "				<NOMESCORE>P5</NOMESCORE>";
                resposta += "				<CLASSIFICACAONUMERICA>05</CLASSIFICACAONUMERICA>";
                resposta += "				<CLASSIFICACAOALFABETICA>A</CLASSIFICACAOALFABETICA>";
                resposta += "				<PROBABILIDADE>00100</PROBABILIDADE>";
                resposta += "				<TEXTO>E provavel que 99% das pessoas com esse mesmo comportamento, paguem suas   contas nos proximos 6 meses.</TEXTO>";
                resposta += "				<CODIGONATUREZAMODELO>115</CODIGONATUREZAMODELO>";
                resposta += "				<DESCRICAONATUREZA>POSITIVO PF</DESCRICAONATUREZA>";
                resposta += "			</SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "			<SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "				<TAMANHOREGISTRO>462</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>601</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOSCORE>1</TIPOSCORE>";
                resposta += "				<SCORE>9</SCORE>";
                resposta += "				<VALOR>0</VALOR>";
                resposta += "				<PLANOEXECUCAO>N</PLANOEXECUCAO>";
                resposta += "				<MODELOPLANO>1F</MODELOPLANO>";
                resposta += "				<MODELOSCORE>1F</MODELOSCORE>";
                resposta += "				<NOMESCORE>RankRnd Positiva P5</NOMESCORE>";
                resposta += "				<CLASSIFICACAONUMERICA>00</CLASSIFICACAONUMERICA>";
                resposta += "				<PROBABILIDADE>00000</PROBABILIDADE>";
                resposta += "				<TEXTO>De R$ 2.001 ate R$ 5.000</TEXTO>";
                resposta += "				<CODIGONATUREZAMODELO>116</CODIGONATUREZAMODELO>";
                resposta += "				<DESCRICAONATUREZA>RENDA PRESUMIDA POSITIVA</DESCRICAONATUREZA>";
                resposta += "				<TEXTO2>Renda estimada a partir de informacoes comportamentais e cadastrais do consumidor.</TEXTO2>";
                resposta += "			</SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "			<PAINEL-CONTROLE-POSITIVO>";
                resposta += "				<NOTA-COMPORTAMENTO-FATURA-EM-ATRASO>";
                resposta += "					<NOTA>A</NOTA>";
                resposta += "				</NOTA-COMPORTAMENTO-FATURA-EM-ATRASO>";
                resposta += "				<NOTA-COMPORTAMENTO-CONTRATOS-RECENTES>";
                resposta += "					<NOTA>A</NOTA>";
                resposta += "				</NOTA-COMPORTAMENTO-CONTRATOS-RECENTES>";
                resposta += "			</PAINEL-CONTROLE-POSITIVO>";
                resposta += "			<MENSAGEM-REGISTRO>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>940</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</MENSAGEM-REGISTRO>";
                resposta += "			<STATUS-CONSUMIDOR>";
                resposta += "				<MENSAGEM>CONSUMIDOR PARTICIPANTE DO CADASTRO POSITIVO COM INFORMACAO</MENSAGEM>";
                resposta += "			</STATUS-CONSUMIDOR>";
                resposta += "			<RESUMOCONSULTAS-ANTERIORES-90-DIAS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>111</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMOCONSULTAS-ANTERIORES-90-DIAS>";
                resposta += "			<CONSULTAS-ANTERIORES>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>126</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</CONSULTAS-ANTERIORES>";
                resposta += "		</ACERTA>";
                resposta += "	</RESPOSTA>";
                resposta += "</SPCA-XML>";
            }
            else if (parametro.SOLICITACAO.SCPF == "22233344405")
            {
                resposta += "<?xml version=\"1.0\" encoding=\"ISO - 8859 - 1\"?>";
                resposta += "<SPCA-XML xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"https://www.scpc.inf.br/spcn/spcaxmlacerta.xsd\">";
                resposta += "	<VERSAO>20090415</VERSAO>";
                resposta += "	<SOLICITACAO>";
                resposta += "		<S-REGIONAL>0</S-REGIONAL>";
                resposta += "		<S-CODIGO>666</S-CODIGO>";
                resposta += "		<S-CONSULTA>353</S-CONSULTA>";
                resposta += "		<S-SOLICITANTE/>";
                resposta += "		<S-CPF>" + parametro.SOLICITACAO.SCPF + "</S-CPF>";
                resposta += "		<S-DDD-1>19</S-DDD-1>";
                resposta += "		<S-TELEFONE-1>99990000</S-TELEFONE-1>";
                resposta += "		<S-CEP>0</S-CEP>";
                resposta += "		<S-ACERTA-PRODUTO>";
                resposta += "			<S-ACERTA-SCORE>N</S-ACERTA-SCORE>";
                resposta += "			<S-ACERTA-SCORE-MODELO/>";
                resposta += "			<S-ACERTA-CHEQUE>N</S-ACERTA-CHEQUE>";
                resposta += "		</S-ACERTA-PRODUTO>";
                resposta += "		<S-CHEQUE-ORIGEM/>";
                resposta += "		<S-CHEQUE-DATA>0</S-CHEQUE-DATA>";
                resposta += "		<S-CHEQUE-QTDE>0</S-CHEQUE-QTDE>";
                resposta += "		<S-BANCO>0</S-BANCO>";
                resposta += "		<S-AGENCIA>0</S-AGENCIA>";
                resposta += "		<S-CONTA-CORRENTE>0</S-CONTA-CORRENTE>";
                resposta += "		<S-CONTA-DIGITO>0</S-CONTA-DIGITO>";
                resposta += "		<S-CHEQUE>0</S-CHEQUE>";
                resposta += "		<S-CHEQUE-DIGITO>0</S-CHEQUE-DIGITO>";
                resposta += "		<S-CMC7/>";
                resposta += "		<S-TIPO-CREDITO>OU</S-TIPO-CREDITO>";
                resposta += "		<S-NUMERO-RESPOSTA>0</S-NUMERO-RESPOSTA>";
                resposta += "	</SOLICITACAO>";
                resposta += "	<RESPOSTA>";
                resposta += "		<RESPOSTA-RETORNO>";
                resposta += "			<STATUS-RESPOSTA>0</STATUS-RESPOSTA>";
                resposta += "			<MENSAGEM-RESPOSTA>CONSULTA CONCLUIDA</MENSAGEM-RESPOSTA>";
                resposta += "		</RESPOSTA-RETORNO>";
                resposta += "		<NUMERO-RESPOSTA>123123123-0</NUMERO-RESPOSTA>";
                resposta += "		<ASSOCIADO-SOLICITANTE>REGICRED</ASSOCIADO-SOLICITANTE>";
                resposta += "		<NOME-CONSULTA>ACERTA ESSENCIAL POSITIVO</NOME-CONSULTA>";
                resposta += "		<IP-SOLICITANTE>123.123.123.123</IP-SOLICITANTE>";
                resposta += "		<ACERTA>";
                resposta += "			<RESUMO-DE-ACOES-CIVEIS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>020</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMO-DE-ACOES-CIVEIS>";
                resposta += "			<RELACAO-DE-ACOES-CIVEIS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>021</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RELACAO-DE-ACOES-CIVEIS>";
                resposta += "			<RESUMO-OCORRENCIAS-DE-DEBITOS>";
                resposta += "				<TAMANHOREGISTRO>065</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>108</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TOTALDEVEDOR>2</TOTALDEVEDOR>";
                resposta += "				<TOTALAVALISTA>0</TOTALAVALISTA>";
                resposta += "				<VALORACOMULADO>253,85</VALORACOMULADO>";
                resposta += "				<DATAPRIMEIRODEBITO>17/04/2022</DATAPRIMEIRODEBITO>";
                resposta += "				<VALORPRIMEIRODEBITO>135,73</VALORPRIMEIRODEBITO>";
                resposta += "				<DATAMAIORDEBITO>17/04/2022</DATAMAIORDEBITO>";
                resposta += "				<VALORMAIORDEBITO>135,73</VALORMAIORDEBITO>";
                resposta += "			</RESUMO-OCORRENCIAS-DE-DEBITOS>";
                resposta += "			<INFORMACOES-COMPLEMENTARES>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>123</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</INFORMACOES-COMPLEMENTARES>";
                resposta += "			<DEBITOS>";
                resposta += "				<TAMANHOREGISTRO>138</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>124</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOOCORRENCIA>RG</TIPOOCORRENCIA>";
                resposta += "				<CONTRATO>0001320240</CONTRATO>";
                resposta += "				<DATAOCORRENCIA>25/02/2024</DATAOCORRENCIA>";
                resposta += "				<DATADISPONIBILIZACAO>24/04/2024</DATADISPONIBILIZACAO>";
                resposta += "				<MOEDA>R$</MOEDA>";
                resposta += "				<VALOR>118,12</VALOR>";
                resposta += "				<SITUACAO>C</SITUACAO>";
                resposta += "				<INFORMANTE>ADM.CART CREDITO PALMA/LOJAS CAEDU</INFORMANTE>";
                resposta += "				<INFORMADOPELOCONSULENTE>N</INFORMADOPELOCONSULENTE>";
                resposta += "				<CIDADE>SCPC SAO PAULO</CIDADE>";
                resposta += "				<UF>SP</UF>";
                resposta += "				<CONDICAO>A</CONDICAO>";
                resposta += "				<CONDICAOMUNICIPIO>00000000</CONDICAOMUNICIPIO>";
                resposta += "			</DEBITOS>";
                resposta += "			<DEBITOS>";
                resposta += "				<TAMANHOREGISTRO>138</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>124</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOOCORRENCIA>RG</TIPOOCORRENCIA>";
                resposta += "				<CONTRATO>1318167819</CONTRATO>";
                resposta += "				<DATAOCORRENCIA>17/04/2022</DATAOCORRENCIA>";
                resposta += "				<DATADISPONIBILIZACAO>27/01/2024</DATADISPONIBILIZACAO>";
                resposta += "				<MOEDA>R$</MOEDA>";
                resposta += "				<VALOR>135,73</VALOR>";
                resposta += "				<SITUACAO>C</SITUACAO>";
                resposta += "				<INFORMANTE>TELEFONICA BRASIL S/A/MOVEL/COBRANCA</INFORMANTE>";
                resposta += "				<INFORMADOPELOCONSULENTE>N</INFORMADOPELOCONSULENTE>";
                resposta += "				<CIDADE>SCPC SAO PAULO</CIDADE>";
                resposta += "				<UF>SP</UF>";
                resposta += "				<CONDICAO>A</CONDICAO>";
                resposta += "				<CONDICAOMUNICIPIO>00000000</CONDICAOMUNICIPIO>";
                resposta += "			</DEBITOS>";
                resposta += "			<TITULOS-PROTESTADOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>142</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</TITULOS-PROTESTADOS>";
                resposta += "			<RESUMO-TITULOS-PROTESTADOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>146</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RESUMO-TITULOS-PROTESTADOS>";
                resposta += "			<CONFIRMACAO-TELEFONE>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>223</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</CONFIRMACAO-TELEFONE>";
                resposta += "			<CONFIRMACAO-CEP>";
                resposta += "				<TAMANHOREGISTRO>132</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>227</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<CEP>11723070</CEP>";
                resposta += "				<ENDERECO>R H</ENDERECO>";
                resposta += "				<BAIRRO>VILA SONIA</BAIRRO>";
                resposta += "				<CIDADE>PRAIA GRANDE</CIDADE>";
                resposta += "				<UF>SP</UF>";
                resposta += "			</CONFIRMACAO-CEP>";
                resposta += "			<NOME-DOCUMENTOS>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>241</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</NOME-DOCUMENTOS>";
                resposta += "			<PARTICIPACOES-DO-DOCUMENTO-CONSULTADO>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>282</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</PARTICIPACOES-DO-DOCUMENTO-CONSULTADO>";
                resposta += "			<RELACAO-FALENCIA-RECUPERACAO-JUDICIAL>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>295</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</RELACAO-FALENCIA-RECUPERACAO-JUDICIAL>";
                resposta += "			<IDENTIFICACAO>";
                resposta += "				<TAMANHOREGISTRO>366</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>500</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<DOCUMENTO>" + parametro.SOLICITACAO.SCPF + "</DOCUMENTO>";
                resposta += "				<NOME>LUIS SOUZA</NOME>";
                resposta += "				<NOMEMAE>MARIA SOUZA</NOMEMAE>";
                resposta += "				<DATANASCIMENTO>01/01/1980</DATANASCIMENTO>";
                resposta += "				<DATAEMISSAORG>-</DATAEMISSAORG>";
                resposta += "				<SEXOCONSULTADO>1</SEXOCONSULTADO>";
                resposta += "				<CIDADENASCIMENTO>BRASILEIRO</CIDADENASCIMENTO>";
                resposta += "				<ESTADOCIVIL>0</ESTADOCIVIL>";
                resposta += "				<NUMERODEPENDENTES>0</NUMERODEPENDENTES>";
                resposta += "				<GRAUINSTRUCAO>6</GRAUINSTRUCAO>";
                resposta += "				<SITUACAORECEITA>1</SITUACAORECEITA>";
                resposta += "				<DATAATUALIZACAO>01/08/2024</DATAATUALIZACAO>";
                resposta += "				<REGIAOCPF>8</REGIAOCPF>";
                resposta += "				<TITULOELEITOR>1234567890123</TITULOELEITOR>";
                resposta += "			</IDENTIFICACAO>";
                resposta += "			<LOCALIZACAO>";
                resposta += "				<TAMANHOREGISTRO>323</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>501</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOLOGRADOURO>AV</TIPOLOGRADOURO>";
                resposta += "				<NOMELOGRADOURO>INDEPENDENCIA</NOMELOGRADOURO>";
                resposta += "				<NUMEROLOGRADOURO>123</NUMEROLOGRADOURO>";
                resposta += "				<COMPLEMENTO/>";
                resposta += "				<BAIRRO>CENTRO</BAIRRO>";
                resposta += "				<CIDADE>PIRACICABA</CIDADE>";
                resposta += "				<UNIDADEFEDERATIVA>SP</UNIDADEFEDERATIVA>";
                resposta += "				<CEP>13405000</CEP>";
                resposta += "				<DDD-1>0019</DDD-1>";
                resposta += "				<TELEFONE-1>912341234</TELEFONE-1>";
                resposta += "				<DDD-2>0019</DDD-2>";
                resposta += "				<TELEFONE-2>12345678</TELEFONE-2>";
                resposta += "				<DDD-3>0019</DDD-3>";
                resposta += "				<TELEFONE-3>12345678</TELEFONE-3>";
                resposta += "			</LOCALIZACAO>";
                resposta += "			<SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "				<TAMANHOREGISTRO>462</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>601</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOSCORE>1</TIPOSCORE>";
                resposta += "				<SCORE>286</SCORE>";
                resposta += "				<VALOR>0</VALOR>";
                resposta += "				<PLANOEXECUCAO>N</PLANOEXECUCAO>";
                resposta += "				<MODELOSCORE>1D</MODELOSCORE>";
                resposta += "				<NOMESCORE>P5</NOMESCORE>";
                resposta += "				<CLASSIFICACAONUMERICA>12</CLASSIFICACAONUMERICA>";
                resposta += "				<CLASSIFICACAOALFABETICA>C</CLASSIFICACAOALFABETICA>";
                resposta += "				<PROBABILIDADE>01800</PROBABILIDADE>";
                resposta += "				<TEXTO>E provavel que 82% das pessoas com esse mesmo comportamento, paguem suas   contas nos proximos 6 meses.</TEXTO>";
                resposta += "				<CODIGONATUREZAMODELO>115</CODIGONATUREZAMODELO>";
                resposta += "				<DESCRICAONATUREZA>POSITIVO PF</DESCRICAONATUREZA>";
                resposta += "			</SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "			<SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "				<TAMANHOREGISTRO>462</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>601</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOSCORE>1</TIPOSCORE>";
                resposta += "				<SCORE>3</SCORE>";
                resposta += "				<VALOR>0</VALOR>";
                resposta += "				<PLANOEXECUCAO>N</PLANOEXECUCAO>";
                resposta += "				<MODELOPLANO>1F</MODELOPLANO>";
                resposta += "				<MODELOSCORE>1F</MODELOSCORE>";
                resposta += "				<NOMESCORE>RankRnd Positiva P5</NOMESCORE>";
                resposta += "				<CLASSIFICACAONUMERICA>00</CLASSIFICACAONUMERICA>";
                resposta += "				<PROBABILIDADE>00000</PROBABILIDADE>";
                resposta += "				<TEXTO>De R$ 1.401 ate R$ 2.000</TEXTO>";
                resposta += "				<CODIGONATUREZAMODELO>116</CODIGONATUREZAMODELO>";
                resposta += "				<DESCRICAONATUREZA>RENDA PRESUMIDA POSITIVA</DESCRICAONATUREZA>";
                resposta += "				<TEXTO2>Renda estimada a partir de informacoes comportamentais e cadastrais do consumidor.</TEXTO2>";
                resposta += "			</SCORE-CLASSIFICACAO-VARIOS-MODELOS>";
                resposta += "			<PAINEL-CONTROLE-POSITIVO>";
                resposta += "				<NOTA-COMPORTAMENTO-FATURA-EM-ATRASO>";
                resposta += "					<NOTA>B</NOTA>";
                resposta += "				</NOTA-COMPORTAMENTO-FATURA-EM-ATRASO>";
                resposta += "				<NOTA-COMPORTAMENTO-CONTRATOS-RECENTES>";
                resposta += "					<NOTA>A</NOTA>";
                resposta += "				</NOTA-COMPORTAMENTO-CONTRATOS-RECENTES>";
                resposta += "			</PAINEL-CONTROLE-POSITIVO>";
                resposta += "			<MENSAGEM-REGISTRO>";
                resposta += "				<TAMANHOREGISTRO>004</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>940</TIPOREGISTRO>";
                resposta += "				<REGISTRO>N</REGISTRO>";
                resposta += "			</MENSAGEM-REGISTRO>";
                resposta += "			<STATUS-CONSUMIDOR>";
                resposta += "				<MENSAGEM>CONSUMIDOR PARTICIPANTE DO CADASTRO POSITIVO COM INFORMACAO</MENSAGEM>";
                resposta += "			</STATUS-CONSUMIDOR>";
                resposta += "			<RESUMOCONSULTAS-ANTERIORES-90-DIAS>";
                resposta += "				<TAMANHOREGISTRO>49</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>111</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TOTAL>00003</TOTAL>";
                resposta += "				<ANO-1>2024</ANO-1>";
                resposta += "				<MES-1>11</MES-1>";
                resposta += "				<TOTAL-1>0001</TOTAL-1>";
                resposta += "				<ANO-2>2024</ANO-2>";
                resposta += "				<MES-2>10</MES-2>";
                resposta += "				<TOTAL-2>0001</TOTAL-2>";
                resposta += "				<ANO-3>2024</ANO-3>";
                resposta += "				<MES-3>09</MES-3>";
                resposta += "				<TOTAL-3>0001</TOTAL-3>";
                resposta += "				<ANO-4>2024</ANO-4>";
                resposta += "				<MES-4>08</MES-4>";
                resposta += "				<TOTAL-4>0000</TOTAL-4>";
                resposta += "			</RESUMOCONSULTAS-ANTERIORES-90-DIAS>";
                resposta += "			<CONSULTAS-ANTERIORES>";
                resposta += "				<TAMANHOREGISTRO>66</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>126</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOOCORRENCIA>CD</TIPOOCORRENCIA>";
                resposta += "				<DATA>21/09/2024</DATA>";
                resposta += "				<VALOR>0,00</VALOR>";
                resposta += "				<INFORMANTE>JEITTO MEIOS DE PAGAMENTO LTDA</INFORMANTE>";
                resposta += "				<PRODUTO>S</PRODUTO>";
                resposta += "			</CONSULTAS-ANTERIORES>";
                resposta += "			<CONSULTAS-ANTERIORES>";
                resposta += "				<TAMANHOREGISTRO>66</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>126</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOOCORRENCIA>OU</TIPOOCORRENCIA>";
                resposta += "				<DATA>15/11/2024</DATA>";
                resposta += "				<VALOR>0,00</VALOR>";
                resposta += "				<INFORMANTE>CAIXA ECONOMICA FEDERAL</INFORMANTE>";
                resposta += "				<PRODUTO>N</PRODUTO>";
                resposta += "			</CONSULTAS-ANTERIORES>";
                resposta += "			<CONSULTAS-ANTERIORES>";
                resposta += "				<TAMANHOREGISTRO>66</TAMANHOREGISTRO>";
                resposta += "				<TIPOREGISTRO>126</TIPOREGISTRO>";
                resposta += "				<REGISTRO>S</REGISTRO>";
                resposta += "				<TIPOOCORRENCIA>OU</TIPOOCORRENCIA>";
                resposta += "				<DATA>23/10/2024</DATA>";
                resposta += "				<VALOR>0,00</VALOR>";
                resposta += "				<INFORMANTE>CAIXA ECONOMICA FEDERAL</INFORMANTE>";
                resposta += "				<PRODUTO>N</PRODUTO>";
                resposta += "			</CONSULTAS-ANTERIORES>";
                resposta += "		</ACERTA>";
                resposta += "	</RESPOSTA>";
                resposta += "</SPCA-XML>";
            }

            var serializer = new XmlSerializer(typeof(SPCAXML));
            using (TextReader reader = new StringReader(resposta))
            {
                response = (SPCAXML)serializer.Deserialize(reader);
            }

            return response;
        }


    }
}

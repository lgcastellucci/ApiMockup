namespace ApiMockup
{
    public class Uteis
    {
        public DateTime UltimoDiaDoMes()
        {
            return UltimoDiaDoMes(DateTime.Now);
        }
        public DateTime UltimoDiaDoMes(DateTime dataReferencia)
        {
            // Informe o ano e o mês desejados
            int ano = dataReferencia.Year;
            int mes = dataReferencia.Month;

            // Obtém o último dia do mês
            int ultimoDiaDoMes = DateTime.DaysInMonth(ano, mes);

            // Cria uma instância de DateTime representando o último dia do mês
            var ultimoDia = new DateTime(ano, mes, ultimoDiaDoMes);

            return ultimoDia;
        }
    }
}

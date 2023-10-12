namespace ApiMockup
{
    public class Uteis
    {
        public DateTime UltimoDiaDoMesAtual()
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

        public DateTime QualquerDataDoAnoAnterior()
        {
            var dataReferencia = DateTime.Now.AddYears(-1);

            var random = new Random();
            int dia = random.Next(1, 28);
            int mes = random.Next(1, 12);

            return new DateTime(dataReferencia.Year, mes, dia);
        }

        public DateTime QualquerDataDepoisDeHojeNoMesAtual()
        {
            var dataAtual = DateTime.Now;

            var random = new Random();
            int dia = random.Next(dataAtual.Day + 1, 28);

            return new DateTime(dataAtual.Year, dataAtual.Month, dia);
        }
    }
}

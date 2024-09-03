using System.Text.Json;

namespace FaturamentoDistribuidora
{
    class Program
    {
        public static void Main(String[] args)
        {

            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Faturamento052024.json");

                string jsonString = File.ReadAllText(filePath);

                FaturamentoMensal faturamentoMensal = JsonSerializer.Deserialize<FaturamentoMensal>(jsonString);

                if (faturamentoMensal != null && faturamentoMensal.Faturamento != null)
                {
                    MenorValorDoMes.Execute(faturamentoMensal.Faturamento);
                    MaiorValorDoMes.Execute(faturamentoMensal.Faturamento);
                    MediaMensal.Execute(faturamentoMensal.Faturamento);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
            }
        }
    }
}
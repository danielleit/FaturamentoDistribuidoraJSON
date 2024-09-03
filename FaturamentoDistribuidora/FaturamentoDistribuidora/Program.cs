using System.Text.Json;

namespace FaturamentoDistribuidora {
    class Program {
        public static void Main(String[] args) {

            try {
                string fileName = "C:\\Users\\Daniel\\source\\repos\\FaturamentoDistribuidora\\FaturamentoDistribuidora\\Faturamento052024.json";
                string jsonString = File.ReadAllText(fileName);

                FaturamentoMensal faturamentoMensal = JsonSerializer.Deserialize<FaturamentoMensal>(jsonString);

                if (faturamentoMensal != null && faturamentoMensal.Faturamento != null) {
                    MenorValorDoMes(faturamentoMensal.Faturamento);
                    MaiorValorDoMes(faturamentoMensal.Faturamento);
                    MediaMensal(faturamentoMensal.Faturamento);

                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
            }
        }

        public static void MenorValorDoMes(List<FaturamentoDiario> faturamentoMensal) {
            double menorValor = faturamentoMensal[0].Valor;
            int diaDoMes = faturamentoMensal[0].Dia;

            foreach (var fat in faturamentoMensal) {
                if (fat.Valor < menorValor && fat.Valor > 0) {
                    menorValor = fat.Valor;
                    diaDoMes = fat.Dia;
                }
            }

            Console.WriteLine($"O menor valor de faturamento desse mes foi o do dia {diaDoMes} no valor de R$ {menorValor}!");

        }

        public static void MaiorValorDoMes(List<FaturamentoDiario> faturamentoMensal) {
            double maiorValor = faturamentoMensal[0].Valor;
            int diaDoMes = 0;

            foreach (var fat in faturamentoMensal) {
                if (fat.Valor > maiorValor) {
                    maiorValor = fat.Valor;
                    diaDoMes = fat.Dia;
                }
            }

            Console.WriteLine($"O maior valor de faturamento desse mes foi o do dia {diaDoMes} no valor de R$ {maiorValor}!");

        }

        public static void MediaMensal(List<FaturamentoDiario> faturamentoMensal) {
            double mediaMensal = 0;
            int somaDosDias = 0;

            //calcular media
            foreach (var fat in faturamentoMensal) {
                mediaMensal += fat.Valor;
            }

            mediaMensal /= faturamentoMensal.Count;

            //comparar valores por media
            foreach (var fat in faturamentoMensal) {
                if(fat.Valor > mediaMensal) {
                    somaDosDias += 1;
                }
            }

            Console.WriteLine($"O numero de dias que foi superior a media mensal de R$ {Math.Round(mediaMensal, 2)} foi o total de {somaDosDias} dias!");

        }

    }


}
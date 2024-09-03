using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    internal class MaiorValorDoMes
    {
        public static void Execute(List<FaturamentoDiario> faturamentoMensal)
        {
            double maiorValor = faturamentoMensal[0].Valor;
            int diaDoMes = 0;

            foreach (var fat in faturamentoMensal)
            {
                if (fat.Valor > maiorValor)
                {
                    maiorValor = fat.Valor;
                    diaDoMes = fat.Dia;
                }
            }

            Console.WriteLine($"O maior valor de faturamento desse mes foi o do dia {diaDoMes} no valor de R$ {maiorValor}!");
        }
    }
}

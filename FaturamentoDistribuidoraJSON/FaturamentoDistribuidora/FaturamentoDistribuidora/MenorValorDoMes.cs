using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    internal class MenorValorDoMes
    {
        public static void Execute(List<FaturamentoDiario> faturamentoMensal)
        {
            double menorValor = faturamentoMensal[0].Valor;
            int diaDoMes = faturamentoMensal[0].Dia;

            foreach (var fat in faturamentoMensal)
            {
                if (fat.Valor < menorValor && fat.Valor > 0)
                {
                    menorValor = fat.Valor;
                    diaDoMes = fat.Dia;
                }
            }

            Console.WriteLine($"O menor valor de faturamento desse mes foi o do dia {diaDoMes} no valor de R$ {menorValor}!");
        }
    }
}

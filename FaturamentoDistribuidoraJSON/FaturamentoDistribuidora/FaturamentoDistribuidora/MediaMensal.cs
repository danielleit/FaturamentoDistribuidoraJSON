using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDistribuidora
{
    internal class MediaMensal
    {
        public static void Execute(List<FaturamentoDiario> faturamentoMensal)
        {
            double mediaMensal = 0;
            int somaDosDias = 0;

            //calcular media
            foreach (var fat in faturamentoMensal)
            {
                mediaMensal += fat.Valor;
            }

            mediaMensal /= faturamentoMensal.Count;

            //comparar valores por media
            foreach (var fat in faturamentoMensal)
            {
                if (fat.Valor > mediaMensal)
                {
                    somaDosDias += 1;
                }
            }

            Console.WriteLine($"O numero de dias que foi superior a media mensal de R$ {Math.Round(mediaMensal, 2)} foi o total de {somaDosDias} dias!");

        }
    }    
}

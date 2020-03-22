using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class util_calculos
    {

        //MARGEM DE LUCRO
        public static double margemLucro(double vlInicial, double vlFinal)
        {
            //ex.: compra de um item por 5,00
            //foi vendido por 6,00
            double margem = ((vlFinal - vlInicial) / vlInicial) * 100;
            return margem;
        }

        //Calcula o lucro. Margem de venda sobre custo
        public static double margemVendaSobreCusto(double vlAnterior, double vlAtual)
        {
            double perc = ((vlAnterior / vlAtual) - 1) * 100;
            return perc;
        }

        //MARGEM DE LUCRO
        //CUSTO SOBRE VENDA
        public static double margemLucroSobreVenda(double custo, double venda)
        {
            double margem = (100 - ((custo / venda) * 100));
            return margem;
        }

        //calcula o percentual que um produto representa no total do estoque
        //ex.: qual percentual um produto x representa do meu estoque de 200,00?
        public static double percEstoque(double custo, double totalEstoque)
        {
            double valor = (custo * 100) / totalEstoque;
            return valor;
        }

    }
}

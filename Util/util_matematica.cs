using System;

namespace Util
{
    public static class util_matematica
    {
        public static double calculaValor(double custo, double margem)
        {
            if (custo == 0)
                return 0;

            return (custo / ((margem - 100) / 100) * -1);
        }

        public static double calculaMargem(double custo, double valor)
        {
            if (custo == 0)
                return 0;

            return (valor - custo) / valor * 100;
        }
        
    }
}

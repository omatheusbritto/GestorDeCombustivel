using System;
using System.Globalization;

namespace Calcular
{
    class CalcularConsumo
    {
        public double Litros, Km, ValorAbastecido;
        public int TipoDeCombustivel;

        public double ValorPorLitro()
        {
            double valorlitro = ValorAbastecido / Litros;
            return valorlitro;
        }
        public double ValorPorKm()
        {
            double valorkm = ValorAbastecido / Km;
            return valorkm;
        }
        public double KmPorLitro()
        {
            double kmlitro = Km / Litros;
            return kmlitro;
        }
        public override string ToString()
        {
            return
                $"Valor Abastecido foi R${ValorAbastecido:f2} | Qtda de Litros {Litros:f2} | Km Rodado {Km:f1}\n"
                + $"Valor por Litros R${ValorPorLitro():f2} | Valor por Km R${ValorPorKm():f2} | Km por Litro {KmPorLitro():f1}";
        }
    }
}


// Programa que calcula comsumo de combustivel, mostrando km/litros e R$/litros
using System;
using System.Globalization;

namespace GestorDeConsumoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {

            Calcular.CalcularConsumo usuario = new Calcular.CalcularConsumo();

            Console.WriteLine("Programa de gestão de combustivel");
            Console.WriteLine("\n");
            Console.WriteLine("Tipo de combustivel abastecido \n[1] Etanol | [2] Gasolina");
            usuario.TipoDeCombustivel = int.Parse(Console.ReadLine());
            Console.Write("Quantos litros foi abastecido: ");
            usuario.Litros = double.Parse(Console.ReadLine());
            Console.Write("Valor do abastecimento: R$");
            usuario.ValorAbastecido = double.Parse(Console.ReadLine());
            Console.Write("Km rodados: ");
            usuario.Km = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine(usuario);
        }
    }
}
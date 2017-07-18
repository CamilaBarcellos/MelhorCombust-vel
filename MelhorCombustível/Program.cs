using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorCombustível
{
    class Program
    {
        static void Main(string[] args)
        {
            Combustiveis combustiveis = new Combustiveis();

            Console.WriteLine("Digite o valor do litro do Álcool:\n");
            combustiveis.ValorLitroAlcool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor do litro da Gasolina:\n");
            combustiveis.ValorLitroGasolina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o desempenho médio (Km/litro) do carro com Álcool:\n");
            combustiveis.ConsumoMedioAlcool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o desempenho médio (Km/litro) do carro com Gasolina:\n");
            combustiveis.ConsumoMedioGasolina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite a distância a ser percorrida (em km):\n");
            combustiveis.DistanciaPercorrida = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n----------------------------------------------------------------------------");

            combustiveis.CalcularConsumoAlcool();
            combustiveis.CalcularConsumoGasolina();
            combustiveis.CalcularEconomia();

            
            if(combustiveis.ValorTotalAlcool < combustiveis.ValorTotalGasolina)
            {
                Console.WriteLine("\nÉ mais vantajoso abastecer com álcool.\nO valor será: R${0 :0.##}\nA economia será de R${1 :0.##}", combustiveis.ValorTotalAlcool, combustiveis.EconomiaAlcool);
            }
            
            else if(combustiveis.ValorTotalAlcool == combustiveis.ValorTotalGasolina)
            {
                Console.WriteLine("\nO valor gasto será o mesmo.\nR${0 :0.##}",combustiveis.ValorTotalAlcool);
            }

            else
            {
                Console.WriteLine("\nÉ mais vantajoso abastecer com gasolina.\nO valor será: R${0 :0.##}\nA economia será de R${1 :0.##}", combustiveis.ValorTotalAlcool, combustiveis.EconomiaGasolina); ;
            }


            Console.ReadLine();
        }
    }
}

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

       /*     Console.WriteLine("\nDigite o consumo médio (Km/litro) do carro com Álcool:\n");
            combustiveis.ConsumoMedioAlcool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o consumo médio (Km/litro) do carro com Gasolina:\n");
            combustiveis.ConsumoMedioGasolina = Convert.ToDouble(Console.ReadLine()); */

            Console.WriteLine("\n----------------------------------------------------------------------------");


            if(combustiveis.ValorLitroCalculado >= combustiveis.ValorLitroAlcool)
            {
                Console.WriteLine("\nÉ mais vantajoso abastecer com álcool, pois o valor é inferior a 70% do valor da gasolina.");
            }
            else
            {
                Console.WriteLine("\nÉ mais vantajoso abastecer com gasolina, pois o valor do álcool é superior a 70% do seu valor.");
            }
            
            
            Console.ReadLine();
        }
    }
}

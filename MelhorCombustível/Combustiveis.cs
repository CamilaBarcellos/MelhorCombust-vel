using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorCombustível
{
    class Combustiveis
    {
        public double ValorLitroAlcool { get; set; }
        public double ValorLitroGasolina { get; set; }        
        public double ConsumoMedioAlcool { get; set; }
        public double ConsumoMedioGasolina { get; set; }
        public double DistanciaPercorrida { get; set; }
        public double ValorTotalAlcool { get; set; }
        public double ValorTotalGasolina { get; set; }
        public double EconomiaAlcool { get; set; }
        public double EconomiaGasolina { get; set; }
        

        public void CalcularEconomia()
        {
            EconomiaAlcool = (ValorTotalGasolina - ValorTotalAlcool);
            EconomiaGasolina = (ValorTotalAlcool - ValorTotalGasolina);
        }


        
        
        public void CalcularConsumoAlcool()
        {
            ValorTotalAlcool = (DistanciaPercorrida / ConsumoMedioAlcool) * ValorLitroAlcool;
        }
        
        public void CalcularConsumoGasolina()
        {
            ValorTotalGasolina = (DistanciaPercorrida / ConsumoMedioGasolina) * ValorLitroGasolina;
        }
    }
}

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
 //       public double ConsumoMedioAlcool { get; set; }
 //       public double ConsumoMedioGasolina { get; set; }
        public double ValorLitroCalculado { get; set; }
        
    
        public void CalcularVantagem()
        {
            ValorLitroCalculado = (ValorLitroGasolina * 0.7);
        }
        
    }
}

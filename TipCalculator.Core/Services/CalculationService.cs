using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculationService()
        {

        }

        public decimal TipAmount(decimal subTotal, double generosity)
        {
            return subTotal*(decimal)(generosity/100);
        }
    }
}

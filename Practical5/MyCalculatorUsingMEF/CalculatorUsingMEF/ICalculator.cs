using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUsingMEF
{
    public interface ICalculator
    {
        double GetResult(double FirstNumber, double SecondNumber);
    }
}

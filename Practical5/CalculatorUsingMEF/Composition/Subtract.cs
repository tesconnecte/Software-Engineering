using System;
using System.ComponentModel.Composition;

using Contract;

namespace CompositionHelper
{
    [Export(typeof(ICalculator))]
    [ExportMetadata("CalculatorMetaData", "Subtract")]
    public class Subtract : ICalculator
    {
        public double GetResult(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
using System;
using System.ComponentModel.Composition;

using Contract;

namespace ExportComponents
{
    [Export(typeof(ICalculator))]
    [ExportMetadata("CalculatorMetaData", "Divide")]
    public class Divide : ICalculator
    {
        public double GetResult(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
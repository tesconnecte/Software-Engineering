using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Contract;
using System.ComponentModel.Composition.Hosting;

namespace CompositionHelper
{
    public class CalculatorCompositionHelper
    {
        [ImportMany]
        public System.Lazy<ICalculator, IDictionary<string, object>>[]
               CalPlugins
        { get; set; }

        public void AssembleCalculatorComponents()
        {
            try
            {
                //Step 1: Initialise a new instance of the 
                //System.ComponentModel.Composition.Hosting.AssemblyCatalog  
                //class with the current executing assembly.
                var catalog = new AssemblyCatalog(
                                  Assembly.GetExecutingAssembly());

                //Step 2: Add The assemblies obtained in step 1 to the 
                //CompositionContainer
                var container = new CompositionContainer(catalog);

                //Step 3: Create composable parts, i.e. the Import and
                //Export components
                container.ComposeParts(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public double Execute(double num1, double num2, string operationType)
        {
            double result = 0;
            foreach (var CalPlugin in CalPlugins)
            {
                Console.WriteLine(CalPlugin);
                if ((string)CalPlugin.Metadata["CalculatorMetaData"]
                    == operationType)
                {
                    result = CalPlugin.Value.GetResult(num1, num2);
                    break;
                }
            }
            return result;
        }
    }
}

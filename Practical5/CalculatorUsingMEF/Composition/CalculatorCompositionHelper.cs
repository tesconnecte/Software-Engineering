using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Collections.Generic;

using Contract;

namespace CompositionHelper
{
    public class CalculatorCompositionHelper
    {
        [ImportMany]
        public System.Lazy<ICalculator, IDictionary<string, object>>[] CalPlugins { get; set; }

        public void AssembleCalculatorComponents()
        {
            try
            {
                var aggregateCatalog = new AggregateCatalog();
                
                var directoryPath = @"d:\lib";
                var directoryCatalog = new DirectoryCatalog(directoryPath, "*.dll");

                var asmCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());

                aggregateCatalog.Catalogs.Add(directoryCatalog);
                aggregateCatalog.Catalogs.Add(asmCatalog);

                var container = new CompositionContainer(aggregateCatalog);
                container.ComposeParts(this);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public double Execute(double num1, double num2, string operationType)
        {
            double result = 0;
            foreach (var CalPlugin in CalPlugins)
            {
                if ((string)CalPlugin.Metadata["CalculatorMetaData"] == operationType)
                {
                    result = CalPlugin.Value.GetResult(num1, num2);
                    break;
                }
            }
            return result;
        }
    }
}
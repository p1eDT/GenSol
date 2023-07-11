using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bdd.StepDefinitions
{
    [Binding]
    internal class Hooks
    {
        [BeforeFeature] 
        public static void BeforeFeature() { }

        [BeforeScenario] 
        public static void BeforeScenario() { }

        [BeforeScenario("@Calculator")]
        public static void BeforeScenarioCalculator() 
        {
            Console.WriteLine("Start calculator");
        }

        [AfterFeature] 
        public static void AfterFeature() { }

        [AfterScenario] 
        public static void AfterScenario() { }

        [AfterScenario("@Calculator")]
        public static void AfterScenarioCalculator()
        {
            Console.WriteLine("Stop calculator");
        }
    }
}

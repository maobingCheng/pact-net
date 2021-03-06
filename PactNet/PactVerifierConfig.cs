using System.Collections.Generic;
using PactNet.Infrastructure.Outputters;

namespace PactNet
{
    public class PactVerifierConfig
    {
        public IEnumerable<IOutput> Outputters { get; set; }

        public PactVerifierConfig()
        {
            Outputters = new List<IOutput>
            {
                new ConsoleOutput()
            };
        }
    }
}